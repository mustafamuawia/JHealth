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


	
   public class BookingDoctorService
    {
   
        private SqlConnection conn = null;
        public delegate void OnBookingCallBack(object sender);
        public event OnBookingCallBack OnBooking;
        void Initialization()
        {
            // Create a dependency connection.
            SqlDependency.Start(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString(), "Register");
        } 
        
        public BookingDoctorService()
        {
            SqlDependency.Stop(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());
            // connector = new DatabaseConnector();
            SqlDependency.Start(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());
            
            conn = new SqlConnection(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());
            GetBookByDoctorId(-1,(int)CLS.BRANCH_ID, Properties.Settings.Default.PROG_ID,CLS.PROCNAME);
        }
        /* public DataTable GetBookByDoctorId(int doctorId)
         {
             return connector.ExcuteProcdure("GET_BOOKDOCTOR_INFO_SHOW_1",
              new SqlParameter[] {
             new SqlParameter("@ID_DOCTOR", doctorId)
              }, true);
         }*/
        
        public DataTable GetBookByDoctorId(int doctorId,int branch_id,int ID_F,String PROCNAME)
        {
            // Assume connection is an open SqlConnection.

           
            conn = new SqlConnection(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());
            
                var cmd = new SqlCommand(PROCNAME, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_DOCTOR",System.Data.SqlDbType.Int).Value= doctorId;
                cmd.Parameters.Add("@ID_BRANCH", System.Data.SqlDbType.Int).Value = branch_id;
                cmd.Parameters.AddWithValue("@BOOK_DATE", System.Data.SqlDbType.Date).Value = DateTime.Now.Date;
                cmd.Parameters.Add("@ID_FLAG", System.Data.SqlDbType.Int).Value = ID_F;
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

        ~BookingDoctorService()
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

            if (OnBooking != null)
            {
                OnBooking(this);
            }
            GetBookByDoctorId(-1,(int)CLS.BRANCH_ID, Properties.Settings.Default.PROG_ID,CLS.PROCNAME);
        }

        void Termination()
        {
            // Release the dependency.
            SqlDependency.Stop(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());
        }/*
        private readonly DatabaseConnector connector;
        public delegate void OnBookingCallBack(object sender);
        public event OnBookingCallBack OnBooking;
        public BookingDoctorService()
        {
            connector = new DatabaseConnector();
          
        }
        public DataTable GetBookByDoctorId(int doctorId)
        {
            return  connector.ExcuteProcdure("GET_BOOKDOCTOR_INFO_SHOW_1",
             new SqlParameter[] {
            new SqlParameter("@ID_DOCTOR", doctorId)
             }, true);
        }

        public  void Book(BookParamters bookParamters)
        {
             connector.ExcuteProcdure("P_UPDATE_T_BOOKING_DOCT", bookParamters.ToSqlParameters());
            if(OnBooking!=null)
            this.OnBooking(this);
        }

        public void BookBySec(BookBySecParamters bookParamters)
        {
            connector.ExcuteProcdure("P_INSERT_T_BOOKING", bookParamters.ToSqlParameters());
            if (OnBooking != null)
                this.OnBooking(this);
        }

        public void FireBookingEvent(){
        if(OnBooking!=null){
                OnBooking(this);
        }
        }*/
    }
	}
 
 