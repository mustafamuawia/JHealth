using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDICALCLINIC.Services
{
    public class DatabaseConnector
    {
        private SqlConnection _connection;
        private SqlCommand _command;

        #region Utils
        private void Init()
        {
            _connection = new SqlConnection(Properties.Settings.Default["MEDICAL_CLINIC_DBConnectionString"].ToString());
            _command = _connection.CreateCommand();
        }

        private  void Connect()
        {
            if (_connection == null)
            {
                Init();
                if (_connection.State != System.Data.ConnectionState.Open)
                {
                     _connection.Open();
                }
            }
        }

        private async void Disconnect()
        {
            _connection = null;
            _command = null;
            GC.SuppressFinalize(this);
        }
        #endregion
        public  DataTable ExcuteProcdure(string procdureName, SqlParameter[] parameters, bool isReader = false)
        {
             Connect();
            _command.CommandText = procdureName;
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.Clear();
            if (parameters != null)
            {
                _command.Parameters.AddRange(parameters);
            }
            if (isReader)
            {
                var dt = new DataTable();
                dt.Load(_command.ExecuteReader());
                return dt;
            }
             _command.ExecuteNonQuery();
            return null;

        }
        public void SqlExecute(string SQL)
        {
            try
            {
                 Connect();
                _command.CommandText = SQL;
                _command.CommandType = CommandType.Text;
                _command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                Disconnect();
            }


        }

        public void Execute_SQL(String sql, CommandType commandType, params SqlParameter[] param)
        {



            try
            {


                Connect();
                _command.CommandText = sql;
                _command.CommandType = commandType;
                _command.Parameters.AddRange(param);
                string command = "";
                try
                {
                     _command.ExecuteScalar();

                }
                catch
                {
                    _command = new SqlCommand(sql, _connection);
                    _command.CommandType = commandType;
                    _command.Parameters.AddRange(param);
                    _command.ExecuteNonQuery();


                }


                
            }
            catch
            {
                //MessageBox.Show(ex.Message.ToString());
              
            }
            finally
            {
                Disconnect();
            }

        }
        public DataTable ExecteRader(String sql, System.Data.CommandType commandType, params SqlParameter[] param)
        {
            try
            {
                var dt = new DataTable();
                Connect();
                _command.CommandText = sql;
                _command.CommandType = commandType;
                _command.Parameters.AddRange(param);
                dt.Load(_command.ExecuteReader());
                return dt;
            }
            catch //(Exception ex)
            {
                // MessageBox.Show(ex.Message.ToString());
                return null;
            }
            finally
            {
                Disconnect();
            }
        }
        public SqlParameter Parameter(String name, SqlDbType type, object value)
        {
            SqlParameter parm = new SqlParameter();
            parm.ParameterName = name;
            parm.SqlDbType = type;
            parm.Value = value == null ? DBNull.Value : value;
            return parm;
        }

    }
}
