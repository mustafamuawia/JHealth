using MEDICALCLINIC.DIAGNOSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.Services
{
    class LabService
    {

        private SqlConnection conn = null;
        public delegate void OnLabTestCallBack(object sender);
        public event OnLabTestCallBack OnLabTest;
        void Initialization()
        {
            // Create a dependency connection.
            SqlDependency.Start(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());
        }
        public LabService()
        {
            SqlDependency.Stop(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());
            // connector = new DatabaseConnector();
            SqlDependency.Start(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());

            conn = new SqlConnection(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());
            GetAllLabTest(1,true,true);
            
        }
        public DataTable GetAllLabTest(int ID_VAR, bool FLAG_COMP, bool FLAG_ALL)
        {
            // Assume connection is an open SqlConnection.

            conn = new SqlConnection(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());

            var cmd = new SqlCommand("[dbo].[GET_ALL_LABTEST_DOTCOTUSER_FOR_LAB]", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID_VAR", System.Data.SqlDbType.Int).Value = ID_VAR;
            cmd.Parameters.Add("@FLAG_COMP", System.Data.SqlDbType.Bit).Value = FLAG_COMP;
            cmd.Parameters.Add("@FLAG_ALL", System.Data.SqlDbType.Bit).Value = FLAG_ALL;
            cmd.Parameters.AddWithValue("@datenow", System.Data.SqlDbType.Date).Value = DateTime.Now.Date;

            cmd.Notification = null;
            var dt = new DataTable();

            // Create dependency for this command and add event handler
            var dependency = new SqlDependency(cmd);
            dependency.OnChange += new OnChangeEventHandler(OnDependencyChange);

            // execute command to get data
            conn.Open();
            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));

            return dt;

        }

        ~LabService()
        {
            // Stop the dependency before exiting
            SqlDependency.Stop(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());
        }
        // Handler method
        void OnDependencyChange(object sender,
           SqlNotificationEventArgs e)
        {
            SqlDependency dependency = sender as SqlDependency;

            // Notices are only a one shot deal
            // so remove the existing one so a new 
            // one can be added
            dependency.OnChange -= OnDependencyChange;
            //if (Application.OpenForms["FRM_VIDEO_PLAYER"] != null)
            //    ((FRM_VIDEO_PLAYER)Application.OpenForms["FRM_VIDEO_PLAYER"]).FRM_VIDEO_PLAYER_Load(null,null);  // Handle the event (for example, invalidate this cache entry).

            if (OnLabTest != null)
            {
                OnLabTest(this);
            }
            GetAllLabTest(1, true, true);
        }

    }
}