using System;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.OPERA
{
    public partial class FRM_ITEM_OPERATION_TOOLS : MEDICALCLINIC.SETTING.BASEANYFORM
    {
        int CODE_OP;
        int cost_center_code;

        public FRM_ITEM_OPERATION_TOOLS(int ID_OP)
        {
            InitializeComponent();
            CODE_OP = ID_OP;
        }
        public FRM_ITEM_OPERATION_TOOLS( )
        {
            InitializeComponent();
           
        }
        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_ITEM_OPERATION_TOOLS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_H_ITEM' table. You can move, or remove it, as needed.
            this.v_GET_H_ITEMTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_H_ITEM);

            if (Properties.Settings.Default.COST_CENTER_TYPE == 0)
            {
                cost_center_code = 120001;
            }
            else
            {
                cost_center_code = CLS.Cost_Center_MSRF_DR;
            }
        }

        private void BTN_A_ITEMS_Click(object sender, EventArgs e)
        {
            try
            {

                int FoodIndex = -1;
                decimal NUMB_X = 1;

                if (TXT_QTY_I.Text == string.Empty)
                {
                    NUMB_X = 1;
                }
                else
                {
                    NUMB_X = Convert.ToDecimal(TXT_QTY_I.Text);
                }
                // this.p_GET_ITEM_TO_SALETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.P_GET_ITEM_TO_SALE, TXT_BARCODE.Text);
                //   DataTable DT = new DataTable();
                //  DT = this.mEDICAL_CLINIC_DBDataSet.P_GET_ITEM_TO_SALE;

                //if (DT.Rows.Count > 0)
                //{
                for (int i = 0; i < DVGITEMS.Rows.Count; i++)
                {
                    if (iTEM_MAMEComboBox.SelectedValue.ToString().Equals(DVGITEMS.Rows[i].Cells[0].Value.ToString()))
                        FoodIndex = i;

                }
                if (FoodIndex == -1)
                {
                    DVGITEMS.Rows.Add(iTEM_MAMEComboBox.SelectedValue, iTEM_MAMEComboBox.Text, NUMB_X, pRICETextBox.Text, (Convert.ToDecimal(pRICETextBox.Text) * Convert.ToDecimal(NUMB_X)).ToString());



                    //TXT_TOTAL.Text =
                    //         (from DataGridViewRow row in DVGITEMS.Rows
                    //          where row.Cells[4].FormattedValue.ToString() != string.Empty
                    //          select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                }
                else
                {
                    
                    DVGITEMS.Rows[FoodIndex].Cells[2].Value = (Convert.ToInt32(DVGITEMS.Rows[FoodIndex].Cells[2].Value) + NUMB_X).ToString();
                    double num = Convert.ToDouble(DVGITEMS.Rows[FoodIndex].Cells[2].Value);

                    DVGITEMS.Rows[FoodIndex].Cells[4].Value = ((num) * Convert.ToDouble(DVGITEMS.Rows[FoodIndex].Cells[3].Value)).ToString();




                    //TXT_TOTAL.Text =
                    //         (from DataGridViewRow row in DVGITEMS.Rows
                    //          where row.Cells[4].FormattedValue.ToString() != string.Empty
                    //          select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                }


                //dgv_order.CurrentRow.Cells[4].Value = (Convert.ToDecimal(dgv_order.CurrentRow.Cells[2].Value) * Convert.ToDecimal(dgv_order.CurrentRow.Cells[3].Value));
                    LBL_TOTAL.Text = DVGITEMS.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToDecimal(t.Cells[4].Value)).ToString();




                //TXT_TOTAL.Text =
                //(from DataGridViewRow row in dgv_order.Rows
                // where row.Cells[4].FormattedValue.ToString() != string.Empty
                // select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                //TXT_BARCODE.Clear();
                //  }


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            
                var INSERTINVDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                for (int i = 0; i < DVGITEMS.Rows.Count; i++)
                {
                    INSERTINVDET.P_INSERT_T_H_ITEMS_OPERATIONS_(
                     Convert.ToInt32(DVGITEMS.Rows[i].Cells[0].Value)
                    , DVGITEMS.Rows[i].Cells[1].Value.ToString()
                    , Convert.ToDecimal(DVGITEMS.Rows[i].Cells[2].Value)
                    , Convert.ToDecimal(DVGITEMS.Rows[i].Cells[3].Value)
                    , Convert.ToDecimal(DVGITEMS.Rows[i].Cells[4].Value)
                    , CODE_OP
                    , ref CLS.SUBMIT_FLAG);

                }
            var INSERTBOXS = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            var INSERTBOXDET = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            int BookIdS = int.Parse(INSERTBOXS.P_INSERT_T_BOX_T(
                        CODE_OP
                       , System.DateTime.Now
                       , " مصاريف عمليات "
                       , 20
                       , 0
                       , true
                       , CLS.USER_CODE
                       , ref CLS.SUBMIT_FLAG
                       , CLS.BRANCH_ID
                       , cost_center_code
                       ).ToString());


            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
                            (
                             BookIdS
                            , 513
                            , " مصاريف عمليات"
                            , 0
                            , 0
                            , Convert.ToDecimal(LBL_TOTAL.Text)
                            , 0
                            , "من حساب الزبون الى حساب الصندوق"
                            , 1
                            , 1
                            , ref CLS.SUBMIT_FLAG
                             );

            //TO

            INSERTBOXDET.P_INSERT_T_BOX_DETAILS
            (
              BookIdS
            , 111
            , "مصاريف عمليات"
            , 0
            , 0
            , 0
            , Convert.ToDecimal(LBL_TOTAL.Text)
            , "من حساب الزبون الى حساب الصندوق"
            , 1
            , 1
            , ref CLS.SUBMIT_FLAG
             );
            if (Properties.Settings.Default.PROG_ID==3 || Properties.Settings.Default.PROG_ID == 4)
            {
                ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_EXPENSE.Text = LBL_TOTAL.Text;

            }

            MSG.Msg.Alart(AlartType.Save);
        }

        private void DVGITEMS_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                if (MessageBox.Show("هل انت متأكد من عملية الحذف؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {


                    DVGITEMS.Rows.RemoveAt(DVGITEMS.CurrentRow.Index);
                    LBL_TOTAL.Text = DVGITEMS.Rows.Cast<DataGridViewRow>()
                       .Sum(t => Convert.ToDecimal(t.Cells[4].Value)).ToString();
                }
            }
        }

        private void pRICETextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                this.pRICETextBox.Text = Convert.ToDecimal(this.pRICETextBox.Text).ToString("N0", new System.Globalization.CultureInfo("en-US"));
                this.pRICETextBox.SelectionStart = pRICETextBox.TextLength;

            }
            catch
            {
                return;
            }
        }

        //private void FRM_ITEM_OPERATION_TOOLS_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    ((CLINIC.FRM_CLINIC)Application.OpenForms["FRM_CLINIC"]).TXT_EXPENSE.Text =LBL_TOTAL.Text;

        //}
    }
}
