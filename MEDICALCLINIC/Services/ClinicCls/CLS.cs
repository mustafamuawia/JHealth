using System.Collections.Generic;
using System.Data;

 
    public  class CLS
    {
         public static DataTable Permessions { get; set; }
         public static int GET_REMAIN_DAYS=0;
         public static int wich_op_img=0;
         public static int? BRANCH_ID;
         public static int  DR_WAIT_NAME;
         public static int CODE_BOOK_IMG;
         public static int CODE_PER_IMG;
         public static int CODE_DOC_COMBO;
         public static string TEXT_FOR_REPORT;
         public static int Cost_Center_WARD_DR= 110001;
         public static int Cost_Center_KSHFIA_DR= 11;
         public static int Cost_Center_MSRF_DR= 120001;
         public static int OEN_SALES;
         public static int F_SEARCH_PAID;
         public static int ID_BOOK_PRINT;
         public static int DOCTOR_CODE_ADD_IMG;
         public static int? DOCTOR_CODE_GENE;
         public static int? DOCTOR_GROP_GENE;
         public static int FALGE_PERSON_IMG=-1;
         public static int ID_PERSON_IMG;
         public static int ID_DOCTOR_IMG;
         public static int ID_BOOKING_IMG;
         public static string PERSON_NAME_IMGE;
         public static int BOOK_FLAG;
         public static int PER_RPT_F;
         public static string FLAGE_NAME;
        // public static int? ACCOUNT_CODE;
         public static int? LEVEL_CODE;
         public static int? USER_CODE;
         public static int? GROUP_ROLEID;
         public static string USER_NAME;
         public static int  Flag_SANAD_S;
         public static string DESC_CODE ;
         public static string DESC_NAME;
         public static string DESC_CODEGRB;
         public static string PROCNAME;

         //public static string TYPEACTIE;
         //public static string ENDTRIALVER;

         public static string DESC_NAMEGRB;
         public static string SANAD_DISCRIPTION ; 
         public static int  CHEECK_CODE;
         public static int? CLIENT_CODE=0, OP_CODE = 0, SUBMIT_FLAG = 0;
         public static int?   ID_BOOK_RET = 0;
         public static int? CLIENT_CODE_DR = 0;
         public static int? CLIENT_CODE_PER = 0;
         public static int? CLIENT_CODE_DR_XRY = 0;
         public static int? CLIENT_CODE_PER_XRY = 0;
         public static int?  SUBMIT_IS_BOOK = 0;
         public static string TITEL_MESG = "MEDICALCLINIC";
         public static string TEST_T = ""; 
         public static string NO_COMP_MSG =" العملية غير مسموح بها";
         public static string COMP_MSG_SAVE = " تمت عملية الحفظ بنجاح";
         public static string COMP_MSG_UPDATE = " تمت عملية التعديل بنجاح";
         public static string COMP_MSG_DELETE = " تمت عملية الحذف بنجاح";
         public static string TXT_NULL = " يجب عدم ترك هذا الحق فارغ";
         public static string Q_MSG_SAVE = "هل انت متأكـــد من عملية الحفظ؟";
         public static string Q_MSG_UPDATE = "هل انت متأكـــد من عملية التعديل؟";
         public static string Q_MSG_DELETE = "هل انت متأكـــد من عملية الحذف؟";
         public static string OP_SAVE = " عملية الحفظ";
         public static string OP_UPDATE = "عملية تعديل ";
         public static string OP_DELETE = "عملية حذف ";
         public static string BOOK_TYPE_PRT ;
         public static string F_DATE_PRT;
         public static string E_DATE_PRT;

        public static string CANAL_UPPER_S;
        public static string CANAL_LOWER_S;
        public static string CANAL_UPPER_N;
        public static string CANAL_LOWER_N;
       
    
        public static List<string> DiagnosisName = new List<string>();
        public static List<string> Treat1 = new List<string>();
        public static List<string> Treat2 = new List<string>();
        public static List<string> Treat3 = new List<string>();
        public static List<string> MainListTooth = new List<string>();
        

    public static string PERSON_CODE_BORROW;
        public static int TIMER_BORROW=0;
        public static int H_MAINPART = 0;
        public static int H_SUBDEP = 0;
        public static int H_FLOOR = 0;
        public static int H_ROOM = 0;
        public static int H_ROOM_BED = 0;
       
        
    }
 
