using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDICALCLINIC.Services
{
    public class BookParamters
    {
        public int _BOOKING_CODE;
        public int _PERSON_CODE;
        public int _DOCTOR_CODE;
        public string _BOOKING_TYPE;
        public string _DISEASE_TYPE;
        public string _DESCRPTION;
        public string _STATE_NAME;
        public string _DRAGE_NAME;
        public string _PRICE_OP;
        public bool _ACTIVE_BOOKING;
        public bool _CHECKED_DOC;
        public bool _ENTER_TO_DOC;
        public int _SUBMIT_FLAG;
        public SqlParameter[] ToSqlParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@BOOKING_CODE", _BOOKING_CODE),
                new SqlParameter("@PERSON_CODE", _PERSON_CODE),
                new SqlParameter("@DOCTOR_CODE", _DOCTOR_CODE),
                new SqlParameter("@BOOKING_TYPE", _BOOKING_TYPE),
                new SqlParameter("@DISEASE_TYPE", _DISEASE_TYPE),
                new SqlParameter("@DESCRPTION", _DESCRPTION),
                new SqlParameter("@STATE_NAME", _STATE_NAME),
                new SqlParameter("@DRAGE_NAME", _DRAGE_NAME),
                new SqlParameter("@PRICE_OP", _PRICE_OP),
                new SqlParameter("@ACTIVE_BOOKING", _ACTIVE_BOOKING),
                new SqlParameter("@CHECKED_DOC", _CHECKED_DOC),
                new SqlParameter("@ENTER_TO_DOC", _ENTER_TO_DOC),
                new SqlParameter("@SUBMIT_FLAG",0){
                Direction=ParameterDirection.Output
                }
            };
            }
    }

    public class BookBySecParamters
    {
        public int _BOOKING_CODE;
        public int _PERSON_CODE;
        public int _DOCTOR_CODE;
        public string _BOOKING_TYPE;
        public string _DISEASE_TYPE;
        public string _DESCRPTION;
        public string _STATE_NAME;
        public string _DRAGE_NAME;
        public string _PRICE_OP;
        public bool _ACTIVE_BOOKING;
        public bool _CHECKED_DOC;
        public bool _ENTER_TO_DOC;
        public int _SUBMIT_FLAG;
        public SqlParameter[] ToSqlParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@BOOKING_CODE", _BOOKING_CODE),
                new SqlParameter("@PERSON_CODE", _PERSON_CODE),
                new SqlParameter("@DOCTOR_CODE", _DOCTOR_CODE),
                new SqlParameter("@BOOKING_TYPE", _BOOKING_TYPE),
                new SqlParameter("@DISEASE_TYPE", _DISEASE_TYPE),
                new SqlParameter("@DESCRPTION", _DESCRPTION),
                new SqlParameter("@STATE_NAME", _STATE_NAME),
                new SqlParameter("@DRAGE_NAME", _DRAGE_NAME),
                new SqlParameter("@PRICE_OP", _PRICE_OP),
                new SqlParameter("@ACTIVE_BOOKING", _ACTIVE_BOOKING),
                new SqlParameter("@CHECKED_DOC", _CHECKED_DOC),
                new SqlParameter("@ENTER_TO_DOC", _ENTER_TO_DOC),
                new SqlParameter("@SUBMIT_FLAG",0){
                Direction=ParameterDirection.Output
                }
            };
        }
    }
}
