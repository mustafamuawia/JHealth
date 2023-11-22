using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MEDICALCLINIC.USERSE
{
    public partial class FRM_ADD_NEWROLE : MEDICALCLINIC.USERSE.masterfrm
    {


        public FRM_ADD_NEWROLE()
        {

            InitializeComponent();
        }

        DataTable dlf = new DataTable();
        DataTable dlp = new DataTable();

        private void FRM_ADD_NEWROLE_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var workingArea = Screen.FromHandle(Handle).WorkingArea;
            MaximizedBounds = new Rectangle(0, 0, workingArea.Width, workingArea.Height);
            WindowState = FormWindowState.Maximized;
            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_FORMS' table. You can move, or remove it, as needed.
            this.v_GET_FORMSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_FORMS);
            var Insrtforms = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            // TODO: This line of code loads data into the 'mEDICAL_CLINIC_DBDataSet.V_GET_GROUP_ROLE' table. You can move, or remove it, as needed.
            this.v_GET_GROUP_ROLETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_GROUP_ROLE);
           
            //Properties.Settings.Default.PROG_ID = 2;
            //Properties.Settings.Default.Save();

            List<string> listfrm;
            List<string> listtbl = new List<string>();
            List<string> newlist = new List<string>();
             
            dlf = this.mEDICAL_CLINIC_DBDataSet.V_GET_FORMS;
           
            listtbl = dlf.ToList<FormsNames>().Select(x => x.ControlType).ToList();
            //List<string>[] list = new List<String>[];
            ////Properties.Settings.Default.PROG_ID = 1;
            ////Properties.Settings.Default.Save();

            if (Properties.Settings.Default.PROG_ID==1)
            {
                listfrm = System.Reflection.Assembly.GetExecutingAssembly().GetTypes().
                       Where(x => typeof(MEDICALCLINIC.HOSPITAL. BaseHospital).IsAssignableFrom(x)||typeof(MEDICALCLINIC. LAB.baselab).IsAssignableFrom(x) || typeof(MEDICALCLINIC. USERSE.masterfrm).IsAssignableFrom(x) || typeof(MEDICALCLINIC. XRAY.basexray).IsAssignableFrom(x) || typeof(MEDICALCLINIC. SETTING.BASEANYFORM).IsAssignableFrom(x) && (!typeof(MEDICALCLINIC. SETTING.baseclinicanddental).IsAssignableFrom(x))).Select(x => x.FullName).ToList();
                newlist = listfrm.Where(x => !listtbl.Any(d => d == x)).ToList();
                foreach (var control in newlist)
                {
                    Type t = Type.GetType(control);
                    var frm = Activator.CreateInstance(t) as Form;
                    if (frm.Text == nameof(MEDICALCLINIC.SETTING.BASEANYFORM)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.SETTING.baseclinicanddental)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.LAB.baselab)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.XRAY.basexray)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.USERSE.masterfrm)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.HOSPITAL.BaseHospital)) continue;
                    int Groupform = int.Parse(
                    Insrtforms.P_INSERT_FormsNames
                    (
                      frm.Name
                    , frm.Text
                    , ""
                    , ""
                    , control

                    ).ToString());
                }
            }
            else
            if (Properties.Settings.Default.PROG_ID == 2)
            {
                listfrm = System.Reflection.Assembly.GetExecutingAssembly().GetTypes().
                       Where(x =>   typeof(MEDICALCLINIC.LAB.baselab).IsAssignableFrom(x) || typeof(MEDICALCLINIC.USERSE.masterfrm).IsAssignableFrom(x) && (!typeof(MEDICALCLINIC.SETTING.baseclinicanddental).IsAssignableFrom(x)) && (!typeof(MEDICALCLINIC.HOSPITAL.BaseHospital).IsAssignableFrom(x))).Select(x => x.FullName).ToList();
                newlist = listfrm.Where(x => !listtbl.Any(d => d == x)).ToList();
                foreach (var control in newlist)
                {
                    Type t = Type.GetType(control);
                    var frm = Activator.CreateInstance(t) as Form;
                    
                    if (frm.Text == nameof(MEDICALCLINIC.SETTING.BASEANYFORM)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.SETTING.baseclinicanddental)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.LAB.baselab)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.USERSE.masterfrm)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.XRAY.basexray)) continue;
                    int Groupform = int.Parse(
                    Insrtforms.P_INSERT_FormsNames
                    (
                      frm.Name
                    , frm.Text
                    , ""
                    , ""
                    , control

                    ).ToString());
                }
            }
            else
            if (Properties.Settings.Default.PROG_ID == 3)
            {
                //if (listtbl.Count!=newlist.Count)
                //{

              
                listfrm = System.Reflection.Assembly.GetExecutingAssembly().GetTypes().
                       Where(x => typeof(MEDICALCLINIC.SETTING.baseclinicanddental).IsAssignableFrom(x) || typeof(MEDICALCLINIC.LAB.baselab).IsAssignableFrom(x) || typeof(MEDICALCLINIC.USERSE.masterfrm).IsAssignableFrom(x) || typeof(MEDICALCLINIC.XRAY.basexray).IsAssignableFrom(x) || typeof(MEDICALCLINIC.SETTING.BASEANYFORM).IsAssignableFrom(x) && (!typeof(MEDICALCLINIC.HOSPITAL.BaseHospital).IsAssignableFrom(x))).Select(x => x.FullName).ToList();
                newlist = listfrm.Where(x => !listtbl.Any(d => d == x)).ToList();
                foreach (var control in newlist)
                {
                    Type t = Type.GetType(control);
                    var frm = Activator.CreateInstance(t) as Form;
                    if (frm.Text == nameof(MEDICALCLINIC.SETTING.BASEANYFORM)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.USERSE.masterfrm)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.SETTING.baseclinicanddental)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.LAB.baselab)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.XRAY.basexray)) continue;
                    int Groupform = int.Parse(
                    Insrtforms.P_INSERT_FormsNames
                    (
                      frm.Name
                    , frm.Text
                    , ""
                    , ""
                    , control

                    ).ToString());
                //}
                
                }
            }
            else
            if (Properties.Settings.Default.PROG_ID == 4)
            {
                //if (listtbl.Count!=newlist.Count)
                //{


                listfrm = System.Reflection.Assembly.GetExecutingAssembly().GetTypes().
                       Where(x => typeof(MEDICALCLINIC.SETTING.baseclinicanddental).IsAssignableFrom(x) || typeof(MEDICALCLINIC.LAB.baselab).IsAssignableFrom(x) || typeof(MEDICALCLINIC.USERSE.masterfrm).IsAssignableFrom(x) || typeof(MEDICALCLINIC.XRAY.basexray).IsAssignableFrom(x) || typeof(MEDICALCLINIC.SETTING.BASEANYFORM).IsAssignableFrom(x) && (!typeof(MEDICALCLINIC.HOSPITAL.BaseHospital).IsAssignableFrom(x))).Select(x => x.FullName).ToList();
                newlist = listfrm.Where(x => !listtbl.Any(d => d == x)).ToList();
                foreach (var control in newlist)
                {
                    Type t = Type.GetType(control);
                    var frm = Activator.CreateInstance(t) as Form;
                    if (frm.Text == nameof(MEDICALCLINIC.SETTING.BASEANYFORM)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC. SETTING.baseclinicanddental)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.LAB.baselab)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.USERSE.masterfrm)) continue;
                    if (frm.Text == nameof(MEDICALCLINIC.XRAY.basexray)) continue;
                    int Groupform = int.Parse(
                    Insrtforms.P_INSERT_FormsNames
                    (
                      frm.Name
                    , frm.Text
                    , ""
                    , ""
                    , control

                    ).ToString());
                    //}

                }
            }

            this.v_GET_FORMSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_FORMS);
            dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.V_GET_FORMS;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.Columns[1].HeaderText = "باسمممس";
            nameComboBox.SelectedIndex = -1;
            Cursor.Current = Cursors.Default;
        }

        private void btn_addper_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var InsrtRols = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
            var Insrtper = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("يرجى أدخال أسم المجموعة اولا .ثم اعادة المحاولة");
                return;
            }
            else
            {
                int GroupRolsId = int.Parse(InsrtRols.P_INSERT_GroupRols(textBox1.Text).ToString());
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    //var row = dataGridView1.Rows[i].Index;
                    
                    // bool isbol =Convert.ToBoolean( IsCheck.Get(row).Value);
                    int permsId = int.Parse(
                    Insrtper.P_INSERT_Permessions(
                      GroupRolsId
                    , Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)
                    , false).ToString());

                }
                this.v_GET_FORMSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_FORMS);
                this.v_GET_GROUP_ROLETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_GROUP_ROLE);
                Cursor.Current = Cursors.Default;
                textBox1.Text = "";
                nameComboBox.SelectedIndex = -1;
                MSG.Msg.Alart(AlartType.Save);
            }
        }

        class FormsNames
        {
            public int id { get; set; }
            public string FormName { get; set; }
            public string FormText { get; set; }
            public string ControlName { get; set; }
            public string ControlText { get; set; }
            public string ControlType { get; set; }
        }
        class Permessions
        {
            public int id { get; set; }
            public int GroupRolsId { get; set; }
            public int FormsNameId { get; set; }
            public bool Value { get; set; }

        }

        private void BTN_UPDATEPER_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var Insrtper = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool fck = false;
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[9].Value) == true)
                {
                    fck = true;
                }

                int permsId = int.Parse(
                Insrtper.P_UPDATE_T_PERMESSION(

                  Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value)
                , Convert.ToInt32(nameComboBox.SelectedValue)
                , fck
                , ref CLS.SUBMIT_FLAG).ToString());

            }
            this.v_GET_FORMSTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.V_GET_FORMS);
            this.gET_permession_formTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_permession_form, new System.Nullable<int>(((int)(System.Convert.ChangeType(nameComboBox.SelectedValue, typeof(int))))));
            CLS.Permessions = this.mEDICAL_CLINIC_DBDataSet.GET_permession_form;
            Cursor.Current = Cursors.Default;
            nameComboBox.SelectedIndex = -1;
            MSG.Msg.Alart(AlartType.Update);
        }



        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {


                this.gET_H_PERMSSION_FROM_BYIDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERMSSION_FROM_BYID, Convert.ToInt32(nameComboBox.SelectedValue));
                dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.GET_H_PERMSSION_FROM_BYID;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                List<int> listfrm;
                List<int> listtbl;
                var InsrtRols = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.QueriesTableAdapter();
                dlf = this.mEDICAL_CLINIC_DBDataSet.V_GET_FORMS;
                dlp = this.mEDICAL_CLINIC_DBDataSet.GET_H_PERMSSION_FROM_BYID;
                listtbl = dlf.ToList<FormsNames>().Select(x => x.id).ToList();
                listfrm = dlp.ToList<Permessions>().Select(x => x.FormsNameId).ToList();
                var newlist = listtbl.Where(x => !listfrm.Any(d => d == x)).ToList();

                foreach (var control in newlist)
                {
                    // Type t = Type.GetType(control);
                    // var frm = Activator.CreateInstance(t) as Form;


                    int permsId = int.Parse(InsrtRols.P_INSERT_Permessions(Convert.ToInt32(nameComboBox.SelectedValue), control, false).ToString());

                }
                if (newlist.Count > 0)
                {
                    this.gET_H_PERMSSION_FROM_BYIDTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_PERMSSION_FROM_BYID, Convert.ToInt32(nameComboBox.SelectedValue));
                    dataGridView1.DataSource = this.mEDICAL_CLINIC_DBDataSet.GET_H_PERMSSION_FROM_BYID;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (System.Exception)
            {
                //  System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewCheckBoxCell cell = this.dataGridView1.CurrentCell as DataGridViewCheckBoxCell;

                if (cell != null && !cell.ReadOnly)
                {
                    cell.Value = cell.Value == null || !((bool)cell.Value);
                    this.dataGridView1.RefreshEdit();
                    this.dataGridView1.NotifyCurrentCellDirty(true);
                }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
                this.dataGridView1.RefreshEdit();
            
        }

        private void btn_selectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                //chk.Value = !(chk.Value == null ? true : (bool)chk.Value); //because chk.Value is initialy null
                row.Cells[9].Value = row.Cells[9].Value == null ? false : !(bool)row.Cells[9].Value;
            }

        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.gET_permession_formTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_permession_form, new System.Nullable<int>(((int)(System.Convert.ChangeType( nameComboBox.SelectedValue, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}