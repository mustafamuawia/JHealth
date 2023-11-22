
using System;
using System.Globalization;
using System.Net;
namespace MEDICALCLINIC.DB_CONFIG
{




    class Helper
    {
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;

            }

        }
        public static DateTime GetDateTime()
        {
            try
            {
                var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
                var response = myHttpWebRequest.GetResponse();
                string todaysDates = response.Headers["date"];
                return DateTime.ParseExact(todaysDates,
                                           "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                                           CultureInfo.InvariantCulture.DateTimeFormat,
                                           DateTimeStyles.AssumeUniversal).Date;

            }
            catch (Exception)
            {

                return DateTime.Today;
            }
        }

    }
}