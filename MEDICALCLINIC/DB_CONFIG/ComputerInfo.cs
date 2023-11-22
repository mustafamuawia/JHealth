using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace MEDICALCLINIC.DB_CONFIG
{
    public class ComputerInfo
    {
        [DllImport("user32", EntryPoint = "CallWindowProcW", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)] private static extern IntPtr CallWindowProcW([In] byte[] bytes, IntPtr hWnd, int msg, [In, Out] byte[] wParam, IntPtr lParam);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)] public static extern bool VirtualProtect([In] byte[] bytes, IntPtr size, int newProtect, out int oldProtect);

        const int PAGE_EXECUTE_READWRITE = 0x40;

        public static string ComputerId()
        {
            byte[] sn = new byte[8];

            if (!ExecuteCode(ref sn))
                return "ND";

            return string.Format("{0}{1}", BitConverter.ToUInt32(sn, 4).ToString("X8"), BitConverter.ToUInt32(sn, 0).ToString("X8"));
        }
        public static string ProductId()
        {
            return ComputerId().Encrypt();
        }
        #region Helper
        private static bool ExecuteCode(ref byte[] result)
        {
            int num;

            /* The opcodes below implement a C function with the signature:
             * __stdcall CpuIdWindowProc(hWnd, Msg, wParam, lParam);
             * with wParam interpreted as a pointer pointing to an 8 byte unsigned character buffer.
             * */

            byte[] code_x86 = new byte[] {
                0x55,                      /* push ebp */
                0x89, 0xe5,                /* mov  ebp, esp */
                0x57,                      /* push edi */
                0x8b, 0x7d, 0x10,          /* mov  edi, [ebp+0x10] */
                0x6a, 0x01,                /* push 0x1 */
                0x58,                      /* pop  eax */
                0x53,                      /* push ebx */
                0x0f, 0xa2,                /* cpuid    */
                0x89, 0x07,                /* mov  [edi], eax */
                0x89, 0x57, 0x04,          /* mov  [edi+0x4], edx */
                0x5b,                      /* pop  ebx */
                0x5f,                      /* pop  edi */
                0x89, 0xec,                /* mov  esp, ebp */
                0x5d,                      /* pop  ebp */
                0xc2, 0x10, 0x00,          /* ret  0x10 */
            };
            byte[] code_x64 = new byte[] {
                0x53,                                     /* push rbx */
                0x48, 0xc7, 0xc0, 0x01, 0x00, 0x00, 0x00, /* mov rax, 0x1 */
                0x0f, 0xa2,                               /* cpuid */
                0x41, 0x89, 0x00,                         /* mov [r8], eax */
                0x41, 0x89, 0x50, 0x04,                   /* mov [r8+0x4], edx */
                0x5b,                                     /* pop rbx */
                0xc3,                                     /* ret */
            };

            byte[] code;

            if (IsX64Process())
                code = code_x64;
            else
                code = code_x86;

            IntPtr ptr = new IntPtr(code.Length);

            if (!VirtualProtect(code, ptr, PAGE_EXECUTE_READWRITE, out num))
                Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());

            ptr = new IntPtr(result.Length);

            return (CallWindowProcW(code, IntPtr.Zero, 0, result, ptr) != IntPtr.Zero);
        }

        private static bool IsX64Process()
        {
            return IntPtr.Size == 8;
        }
        #endregion

    }

    public class KeyManger
    {
        private string ProductId { get; }
        string split = "S@bhy";
        public KeyManger(string ProductId)
        {
            this.ProductId = ProductId;
        }
        public bool GenerateKay(KeyValueClass keyValueClass, ref string ProductKey)
        {
            try
            {


                string AllLicense = ProductId + split;
                AllLicense += keyValueClass.ProductCode + split;
                AllLicense += keyValueClass.Customer + split;
                AllLicense += keyValueClass.TypeLicense + split;
                AllLicense += keyValueClass.ActivetionMethod + split;
                AllLicense += keyValueClass.From.ToDate() + split;
                if (keyValueClass.To != null)
                {
                    AllLicense += keyValueClass.To.ToDate() + split;

                }
                ProductKey = AllLicense.Encrypt();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public KeyInfo UnCode(string ProductKey)
        {
            if (string.IsNullOrEmpty(ProductKey)) return null;
            try
            {
                DateTime? defualtNull = null;
                string[] stringSeparators = new string[] { split };
                var arr = ProductKey.Decrypt().Split(stringSeparators, StringSplitOptions.None);


                var type = (TypeLicense)Enum.Parse(typeof(TypeLicense), arr[3]);
                var activetionMethod = (ActivetionMethod)Enum.Parse(typeof(ActivetionMethod), arr[4]);
                KeyInfo kv = new KeyInfo
                {

                    ProductId = arr[0],
                    ProductCode = Convert.ToInt32(arr[1]),
                    Customer = arr[2],
                    TypeLicense = type,
                    ActivetionMethod = activetionMethod,
                    From = Convert.ToDateTime(arr[5]),
                    To = type == TypeLicense.Trial ? Convert.ToDateTime(arr[6]) : defualtNull
                };
                return kv;
            }
            catch (Exception)
            {
                return null;

            }
        }

        public bool Valid(string ProductKey, int ProductCode)
        {
            try
            {
            if (string.IsNullOrEmpty(ProductKey) || ProductCode == 0) return false;
          
                DateTime CurrentDate = DateTime.Now;

                var kv = UnCode(ProductKey);
                if (kv.ActivetionMethod == ActivetionMethod.Online)
                {
                    if (Helper.CheckForInternetConnection())
                    {
                        CurrentDate = Helper.GetDateTime();
                    }
                    else
                    {

                        return false;
                    }
                }
                if (kv == null) return false;

                if (kv.ProductId != ProductId)
                return false;
                if (kv.ProductCode != ProductCode) return false;
                if (CurrentDate < kv.From.Value) return false;
                if (kv.TypeLicense == TypeLicense.Trial && CurrentDate > kv.To) return false;
                if (kv.TypeLicense == TypeLicense.Trial)
                {
                    Properties.Settings.Default.ENDTRIALVER = kv.To.Value.ToString();
                    Properties.Settings.Default.Save();
                 
                }
                Properties.Settings.Default.TYPEACTIE = kv.TypeLicense.ToString();
                Properties.Settings.Default.Save();
                return true;
            }
            catch (Exception)
            {
            
                return false;

            }
        }
    }
    public class KeyValueClass
    {


        public TypeLicense TypeLicense { get; set; }
        public ActivetionMethod ActivetionMethod { get; set; }
        public string Customer { get; set; }
        public int ProductCode { get; set; }
        public DateTime? From { get; set; } = null;
        public DateTime? To { get; set; } = null;
    }

    public class KeyInfo : KeyValueClass
    {
        public string ProductId { get; set; }
    }
    public enum TypeLicense
    {
        [Display(Name = "Full")]
        Full,
        [Display(Name = "Trial")]
        Trial
    }
    public enum ActivetionMethod
    {
        Offline,
        Online
    }

}
