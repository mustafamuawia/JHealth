using Management_Seles.BaseForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.MSG
{
    class Msg
    {

        public static bool MsgBoxResult(string msg)
        {
            MsResult frm = new MsResult(msg);
            frm.ShowDialog();
            return frm.Result;

        }

        public static void Alart(AlartType alartType, string msg = "", int width = 550, int height = 68)
        {
            MsAlart frm1 = Application.OpenForms["MsAlart"] as MsAlart;
            if (frm1 != null)
            {
                frm1.Close();
                Thread.Sleep(200);
            }
            MsAlart frm = new MsAlart();
            frm.Width = width;
            frm.Height = height;
            switch (alartType)
            {
                case AlartType.Save:
                    msg = msg == "" ? "تم الحفظ بنجاح" : msg;
                    frm.charSet = "f00c";
                    break;
                case AlartType.Update:
                    msg = msg == "" ? "تم التعديل بنجاح" : msg;
                    frm.charSet = "f00c";
                    break;
                case AlartType.Error:
                    msg = msg == "" ? "هناك مشكلة" : msg;
                    frm.charSet = "f00d";
                    break;
                case AlartType.Delete:
                    msg = msg == "" ? "تم الحذف بنجاح" : msg;
                    frm.charSet = "f00d";
                    break;
                case AlartType.help:
                    msg = msg == "" ? "للنقل بين الادوات اضغط علي  انتر || F2 للحفظ اضغط علي  || Esc للخروج من هذه الشاشة اضغط علي " : msg;
                    frm.charSet = "f128";
                    break;

            }


            frm.AlartType = alartType;

            frm.message = msg;

            frm.Show();


        }

    }
}
 
