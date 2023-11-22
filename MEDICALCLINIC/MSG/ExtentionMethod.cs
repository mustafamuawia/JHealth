using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

public static class ExtentionMethod
{
    public static int ToInt(this object x)
    {
        if (x == null) return 0;
        if (x.ToString() == "") return 0;
        return Convert.ToInt32(x);
    }
    public static decimal ToDecimal(this object x)
    {
        if (x == null) return 0;
        if (x.ToString() == "") return 0;
        return Convert.ToDecimal(x);
    }
    public static double ToDouble(this object x)
    {
        if (x == null) return 0;
        if (x.ToString() == "") return 0;
        return Convert.ToDouble(x);
    }
    //public static void Fill(this ComboBox x, object list)
    //{
    //    x.DisplayMember = "Name";
    //    x.ValueMember = "Id";
    //    x.DataSource = list;
    //}
    //public static void Fill(this Green.GreenComboBox x, object list)
    //{
    //    x.DisplayMember = "Name";
    //    x.ValueMember = "Id";
    //    x.DataSource = list;
    //}

    public static DataGridViewCell Get(this DataGridViewColumn column, int Row = -1)
    {
        if (Row == -1)
        {
            return column.DataGridView.CurrentRow.Cells[column.Name];
        }
        else
            return column.DataGridView.Rows[Row].Cells[column.Name];
    }

    public static void IsEmpty(this Control x)
    {
        if (string.IsNullOrWhiteSpace(x.Text))
        {
            x.Focus();
            throw new ArgumentNullException("هناك بعض الحقول فارغة");
        }
    }

    public static void ClearText(this Control FormName)
    {
        foreach (Control ctrl in FormName.Controls)
        {
            if (ctrl is TextBox)
            {
                ctrl.Text = "";
            }
            if (ctrl is PictureBox)
            {
                ((PictureBox)ctrl).Image = null;
            }
            if (ctrl.HasChildren)
            {
                ClearText(ctrl);
            }
        }
    }
    public static Image ToStringImage(this byte[] bytes)
    {
        if (bytes == null)
        {
            return null;
        }
        var bytess = Decompress(bytes);
        var stream = new MemoryStream(bytess);
        return Image.FromStream(stream);
    }

    public static byte[] ToImageString(this Image image)
    {
        if (image == null)
        {
            return null;
        }
        var stream = new MemoryStream();
        image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
        //var bytess = stream.ToArray();
        return Compress(stream.GetBuffer());
    }


    public static string ToEnumDisplay(this Enum x)
    {
        var c = x.GetType().GetMember(x.ToString()).First();
        return c.GetCustomAttribute<DisplayAttribute>() != null ? c.GetCustomAttribute<DisplayAttribute>().Name : c.Name;

    }
    public static string hash
    {
        get
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Books.UI.TextFile1.txt";
            string script = "";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                script += reader.ReadToEnd();

            }
            return script;
        }
    }

    public static string Encrypt(this string Data)
    {
        byte[] data = UnicodeEncoding.UTF8.GetBytes(Data);
        using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        {
            byte[] keys = md5.ComputeHash(UnicodeEncoding.UTF8.GetBytes(hash));
            using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            {

                ICryptoTransform transform = triple.CreateEncryptor();
                byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

                return Convert.ToBase64String(result, 0, result.Length);
            }
        }
    }

    public static string Decrypt(this string Data)
    {
        byte[] data = Convert.FromBase64String(Data);
        using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        {
            byte[] keys = md5.ComputeHash(UnicodeEncoding.UTF8.GetBytes(hash));
            using (TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
            {

                ICryptoTransform transform = triple.CreateDecryptor();
                byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                return UnicodeEncoding.UTF8.GetString(result);
            }
        }
    }

    public static byte[] Compress(this byte[] data)
    {
        MemoryStream output = new MemoryStream();
        using (DeflateStream dstream = new DeflateStream(output, CompressionLevel.Optimal))
        {
            dstream.Write(data, 0, data.Length);
        }
        return output.ToArray();
    }

    public static byte[] Decompress(this byte[] data)
    {
        MemoryStream input = new MemoryStream(data);
        MemoryStream output = new MemoryStream();
        using (DeflateStream dstream = new DeflateStream(input, CompressionMode.Decompress))
        {
            dstream.CopyTo(output);
        }
        return output.ToArray();
    }

    public static List<T> ToList<T>(this DataTable table) where T : class, new()
    {
        try
        {
            List<T> list = new List<T>();

            foreach (var row in table.AsEnumerable())
            {
                T obj = new T();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                    }
                    catch
                    {
                        continue;
                    }
                }

                list.Add(obj);
            }

            return list;
        }
        catch
        {
            return null;
        }
    }


}

