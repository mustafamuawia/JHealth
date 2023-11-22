using MEDICALCLINIC.DB_CONFIG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.Services.Helper
{
    public class Updates:DatabaseConnector
    {

        string CurrentDatabaseVersion = "3.0.1";
        public void CheckForUpdate()
        {
            var pcName = ComputerInfo.ProductId();
            if (string.IsNullOrWhiteSpace(Session.DatabaseVersion))
            {
               
                    var dt = ExecteRader("Select DatabaseVersion from T_LIY where P_NAME=@P_NAME ", CommandType.Text, Parameter("@P_NAME", SqlDbType.NVarChar, pcName));

                if (dt==null)
                {
                    ExecuteUpdate("MEDICALCLINIC.UpdatesNewVersions.Updata1.sql");
                    Session.DatabaseVersion = "3.0.0";
                }
                else
                {
                    Session.DatabaseVersion = dt.Rows[0]["DatabaseVersion"].ToString();
                }

            }
            if (Session.DatabaseVersion == CurrentDatabaseVersion )
            {
                return;
            }

            ExecuteUpdate("MEDICALCLINIC.UpdatesNewVersions.Updata1.sql");
            //if (Session.DatabaseVersion.Replace(".", "").ToInt() <= CurrentDatabaseVersion.Replace(".", "").ToInt())
            //{
            //    ExecuteUpdate("Center_Market.UpdatesNewVersions.ExpensesTypes.sql");
            //}

            Update_Version(pcName, CurrentDatabaseVersion);
          
            Session.DatabaseVersion = CurrentDatabaseVersion;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

        }

        private void ExecuteUpdate(string FileSQlName)
        {
           
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = FileSQlName;
            string script = "";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                script += reader.ReadToEnd();

            }



            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
           
                foreach (string commandString in commandStrings)
                {
                  
                            try
                            {

                               SqlExecute(commandString);
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                    
                }


        }

        public void Update_Version(string P_NAME, string DatabaseVersion)
        {
          
            Execute_SQL("Update T_LIY Set DatabaseVersion=@DatabaseVersion   where P_NAME=@P_NAME", CommandType.Text,
            Parameter("@P_NAME", SqlDbType.NVarChar, P_NAME),
            Parameter("@DatabaseVersion", SqlDbType.NVarChar, DatabaseVersion));


        }



    }
}
