using System.Windows.Forms;

namespace MEDICALCLINIC.SETTING.HOSPITALSETTING
{
    partial class FRM_ADD_BEDS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ADD_BEDS));
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.gET_H_ROOM_BYFLOOR_NAME_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_A_H_FLOORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_A_H_TYPBEDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_A_H_TYPBEDTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_H_TYPBEDTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.v_A_H_FLOORTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_H_FLOORTableAdapter();
            this.gET_H_ROOM_BYFLOOR_NAME_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_H_ROOM_BYFLOOR_NAME_CODETableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nAME_ROOMComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fLOOR_NAMEComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nAME_TYPE_BEDComboBox = new System.Windows.Forms.ComboBox();
            this.PIC_BED = new System.Windows.Forms.PictureBox();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTBEDNAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.gET_H_BED_NAME_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_H_BED_NAME_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_H_BED_NAME_CODETableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iDBEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEBEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFLOORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDROOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pICBEDDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.sTATEBEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPEBEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIVEBEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEROOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLOORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_H_ROOM_BYFLOOR_NAME_CODEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_H_FLOORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_H_TYPBEDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BED)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_H_BED_NAME_CODEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.Locale = new System.Globalization.CultureInfo("ar-IQ");
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gET_H_ROOM_BYFLOOR_NAME_CODEBindingSource
            // 
            this.gET_H_ROOM_BYFLOOR_NAME_CODEBindingSource.DataMember = "GET_H_ROOM_BYFLOOR_NAME_CODE";
            this.gET_H_ROOM_BYFLOOR_NAME_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // v_A_H_FLOORBindingSource
            // 
            this.v_A_H_FLOORBindingSource.DataMember = "V_A_H_FLOOR";
            this.v_A_H_FLOORBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // v_A_H_TYPBEDBindingSource
            // 
            this.v_A_H_TYPBEDBindingSource.DataMember = "V_A_H_TYPBED";
            this.v_A_H_TYPBEDBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // v_A_H_TYPBEDTableAdapter
            // 
            this.v_A_H_TYPBEDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FormsNamesTableAdapter = null;
            this.tableAdapterManager.GroupRolsTableAdapter = null;
            this.tableAdapterManager.MessageTableAdapter = null;
            this.tableAdapterManager.PermessionsTableAdapter = null;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.T_ACCOUNT_COST_TYPETableAdapter = null;
            this.tableAdapterManager.T_ACCOUNT_TYPETableAdapter = null;
            this.tableAdapterManager.T_ACCOUNTSTableAdapter = null;
            this.tableAdapterManager.T_BILL_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOK_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_BOX_DETAILS_TTableAdapter = null;
            this.tableAdapterManager.T_BOX_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_BOX_TTableAdapter = null;
            this.tableAdapterManager.T_BOXTableAdapter = null;
            this.tableAdapterManager.T_CASE_IS_COMPTableAdapter = null;
            this.tableAdapterManager.T_CASH_DEBTTableAdapter = null;
            this.tableAdapterManager.T_CATEGORIESTableAdapter = null;
            this.tableAdapterManager.T_CLASS_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_CLIENT_TYPETableAdapter = null;
            this.tableAdapterManager.T_CLIENTTableAdapter = null;
            this.tableAdapterManager.T_COST_CENTERTableAdapter = null;
            this.tableAdapterManager.T_CURRANNCYTableAdapter = null;
            this.tableAdapterManager.T_DESCRPTIONTableAdapter = null;
            this.tableAdapterManager.T_DISEASETableAdapter = null;
            this.tableAdapterManager.T_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_DRAGE_GROUPTableAdapter = null;
            this.tableAdapterManager.T_DRAGE_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_DRAGETableAdapter = null;
            this.tableAdapterManager.T_EMPLOYEE_TYPETableAdapter = null;
            this.tableAdapterManager.T_EMPLOYEETableAdapter = null;
            this.tableAdapterManager.T_GROUP_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_H_B_DEPTableAdapter = null;
            this.tableAdapterManager.T_H_BEDTableAdapter = null;
            this.tableAdapterManager.T_H_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_H_CATEGORIESTableAdapter = null;
            this.tableAdapterManager.T_H_COMBIN_FSUBTableAdapter = null;
            this.tableAdapterManager.T_H_CONVERTED_BYTableAdapter = null;
            this.tableAdapterManager.T_H_FLOORTableAdapter = null;
            this.tableAdapterManager.T_H_INVOICE_SERVICE_TYPETableAdapter = null;
            this.tableAdapterManager.T_H_ITEMS_OPERATIONSTableAdapter = null;
            this.tableAdapterManager.T_H_ITEMSTableAdapter = null;
            this.tableAdapterManager.T_H_MAIN_DEPTableAdapter = null;
            this.tableAdapterManager.T_H_OP_TYP_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_H_OP_TYPTableAdapter = null;
            this.tableAdapterManager.T_H_OPERATION_CATEGTableAdapter = null;
            this.tableAdapterManager.T_H_OPERATION_PORCEDTableAdapter = null;
            this.tableAdapterManager.T_H_ORGANIZATION_INFOTableAdapter = null;
            this.tableAdapterManager.T_H_ROOMTableAdapter = null;
            this.tableAdapterManager.T_H_RPT_NAME_IMAGETableAdapter = null;
            this.tableAdapterManager.T_H_SCHDUEL_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_H_SERVICE_TYPETableAdapter = null;
            this.tableAdapterManager.T_H_SERVICESTableAdapter = null;
            this.tableAdapterManager.T_H_TYPE_BEDTableAdapter = null;
            this.tableAdapterManager.T_H_TYPE_ROOMTableAdapter = null;
            this.tableAdapterManager.T_IMAGETableAdapter = null;
            this.tableAdapterManager.T_IMG_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_IMG_PERSTableAdapter = null;
            this.tableAdapterManager.T_IMG_RAISTableAdapter = null;
            this.tableAdapterManager.T_INVOICE_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_INVOICESTableAdapter = null;
            this.tableAdapterManager.T_ITEMSTableAdapter = null;
            this.tableAdapterManager.T_L_CAETGORESTableAdapter = null;
            this.tableAdapterManager.T_L_JOIN_CATEG_TESTTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTRAYDETAILSTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTRAYTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTTESTDETAILSTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTTESTTableAdapter = null;
            this.tableAdapterManager.T_L_TESTSTableAdapter = null;
            this.tableAdapterManager.T_L_UNITTableAdapter = null;
            this.tableAdapterManager.T_LAB_NAMETableAdapter = null;
            this.tableAdapterManager.T_LIYTableAdapter = null;
            this.tableAdapterManager.T_MAJOR_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_MAJORTableAdapter = null;
            this.tableAdapterManager.T_MEDICAL_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_MEDICAL_QUESTIONTableAdapter = null;
            this.tableAdapterManager.T_ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_ORDERTableAdapter = null;
            this.tableAdapterManager.T_PERSONTableAdapter = null;
            this.tableAdapterManager.T_PURCHES_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_PURCHESTableAdapter = null;
            this.tableAdapterManager.T_RAY_NAMETableAdapter = null;
            this.tableAdapterManager.T_RAYROOM_NAMETableAdapter = null;
            this.tableAdapterManager.T_REGION_TYPETableAdapter = null;
            this.tableAdapterManager.T_REGIONS_BODYTableAdapter = null;
            this.tableAdapterManager.T_RPT_IMG_LABTableAdapter = null;
            this.tableAdapterManager.T_RPT_IMGTableAdapter = null;
            this.tableAdapterManager.T_SEX_STATETableAdapter = null;
            this.tableAdapterManager.T_STATETableAdapter = null;
            this.tableAdapterManager.T_TOOTH_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_TRATMENT_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_TYPE_MOVETableAdapter = null;
            this.tableAdapterManager.T_TYPE_PAYTableAdapter = null;
            this.tableAdapterManager.T_USERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_A_H_FLOORTableAdapter
            // 
            this.v_A_H_FLOORTableAdapter.ClearBeforeFill = true;
            // 
            // gET_H_ROOM_BYFLOOR_NAME_CODETableAdapter
            // 
            this.gET_H_ROOM_BYFLOOR_NAME_CODETableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel6
            // 
            this.panel6.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.ForeColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(639, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 380);
            this.panel6.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.ForeColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(574, 15);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(4, 275);
            this.panel8.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.ForeColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(2, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 380);
            this.panel5.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(6, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 4);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 2);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.ForeColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(6, 391);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(633, 4);
            this.panel4.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.BTN_EDIT);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 350);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(633, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "خروج";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(119, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "حذف";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.BTN_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EDIT.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EDIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EDIT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_EDIT.Image")));
            this.BTN_EDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EDIT.Location = new System.Drawing.Point(245, 2);
            this.BTN_EDIT.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(119, 36);
            this.BTN_EDIT.TabIndex = 2;
            this.BTN_EDIT.Text = "تعديل";
            this.BTN_EDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EDIT.UseVisualStyleBackColor = false;
            this.BTN_EDIT.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(368, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "حفظ";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(505, 2);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "جديد";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.ForeColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(6, 346);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(633, 4);
            this.panel7.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.57397F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.426025F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 326F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(633, 327);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(298, 323);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.61644F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.38356F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 306);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("STV", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.iDBEDDataGridViewTextBoxColumn,
            this.nAMEBEDDataGridViewTextBoxColumn,
            this.iDFLOORDataGridViewTextBoxColumn,
            this.iDROOMDataGridViewTextBoxColumn,
            this.pICBEDDataGridViewImageColumn,
            this.sTATEBEDDataGridViewTextBoxColumn,
            this.tYPEBEDDataGridViewTextBoxColumn,
            this.aCTIVEBEDDataGridViewTextBoxColumn,
            this.nAMEROOMDataGridViewTextBoxColumn,
            this.fLOORNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gET_H_BED_NAME_CODEBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(2, 49);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STV", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(290, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("STV", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox5.Location = new System.Drawing.Point(2, 2);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(290, 43);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ابحث عن الاسم او الكود هنا";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(2, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.nAME_ROOMComboBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.fLOOR_NAMEComboBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.nAME_TYPE_BEDComboBox);
            this.groupBox4.Controls.Add(this.PIC_BED);
            this.groupBox4.Controls.Add(this.TXTID);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.TXTBEDNAME);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("STV", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox4.Location = new System.Drawing.Point(308, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(323, 323);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اضافة سرير";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(214, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = ":اختيار صورة";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(214, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = ":رقم الغرفة";
            // 
            // nAME_ROOMComboBox
            // 
            this.nAME_ROOMComboBox.DataSource = this.gET_H_ROOM_BYFLOOR_NAME_CODEBindingSource;
            this.nAME_ROOMComboBox.DisplayMember = "NAME_ROOM";
            this.nAME_ROOMComboBox.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold);
            this.nAME_ROOMComboBox.FormattingEnabled = true;
            this.nAME_ROOMComboBox.Location = new System.Drawing.Point(4, 190);
            this.nAME_ROOMComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.nAME_ROOMComboBox.Name = "nAME_ROOMComboBox";
            this.nAME_ROOMComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nAME_ROOMComboBox.Size = new System.Drawing.Size(202, 26);
            this.nAME_ROOMComboBox.TabIndex = 12;
            this.nAME_ROOMComboBox.ValueMember = "ID_ROOM";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(214, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = ":رقم الطابق";
            // 
            // fLOOR_NAMEComboBox
            // 
            this.fLOOR_NAMEComboBox.DataSource = this.v_A_H_FLOORBindingSource;
            this.fLOOR_NAMEComboBox.DisplayMember = "FLOOR_NAME";
            this.fLOOR_NAMEComboBox.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fLOOR_NAMEComboBox.FormattingEnabled = true;
            this.fLOOR_NAMEComboBox.Location = new System.Drawing.Point(4, 55);
            this.fLOOR_NAMEComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.fLOOR_NAMEComboBox.Name = "fLOOR_NAMEComboBox";
            this.fLOOR_NAMEComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fLOOR_NAMEComboBox.Size = new System.Drawing.Size(202, 26);
            this.fLOOR_NAMEComboBox.TabIndex = 10;
            this.fLOOR_NAMEComboBox.ValueMember = "ID_FLOOR";
            this.fLOOR_NAMEComboBox.SelectedIndexChanged += new System.EventHandler(this.fLOOR_NAMEComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(212, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = ":نوع السرير";
            // 
            // nAME_TYPE_BEDComboBox
            // 
            this.nAME_TYPE_BEDComboBox.DataSource = this.v_A_H_TYPBEDBindingSource;
            this.nAME_TYPE_BEDComboBox.DisplayMember = "NAME_TYPE_BED";
            this.nAME_TYPE_BEDComboBox.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nAME_TYPE_BEDComboBox.FormattingEnabled = true;
            this.nAME_TYPE_BEDComboBox.Location = new System.Drawing.Point(4, 286);
            this.nAME_TYPE_BEDComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.nAME_TYPE_BEDComboBox.Name = "nAME_TYPE_BEDComboBox";
            this.nAME_TYPE_BEDComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nAME_TYPE_BEDComboBox.Size = new System.Drawing.Size(202, 24);
            this.nAME_TYPE_BEDComboBox.TabIndex = 8;
            this.nAME_TYPE_BEDComboBox.ValueMember = "ID_TYPE_BED";
            // 
            // PIC_BED
            // 
            this.PIC_BED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PIC_BED.Image = ((System.Drawing.Image)(resources.GetObject("PIC_BED.Image")));
            this.PIC_BED.Location = new System.Drawing.Point(4, 95);
            this.PIC_BED.Margin = new System.Windows.Forms.Padding(2);
            this.PIC_BED.Name = "PIC_BED";
            this.PIC_BED.Size = new System.Drawing.Size(202, 77);
            this.PIC_BED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_BED.TabIndex = 7;
            this.PIC_BED.TabStop = false;
            this.PIC_BED.Click += new System.EventHandler(this.PIC_BED_Click);
            // 
            // TXTID
            // 
            this.TXTID.BackColor = System.Drawing.Color.White;
            this.TXTID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTID.Location = new System.Drawing.Point(50, 22);
            this.TXTID.Margin = new System.Windows.Forms.Padding(2);
            this.TXTID.Name = "TXTID";
            this.TXTID.ReadOnly = true;
            this.TXTID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTID.Size = new System.Drawing.Size(156, 26);
            this.TXTID.TabIndex = 4;
            this.TXTID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(214, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = ":كود السرير";
            // 
            // TXTBEDNAME
            // 
            this.TXTBEDNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXTBEDNAME.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTBEDNAME.Location = new System.Drawing.Point(4, 239);
            this.TXTBEDNAME.Margin = new System.Windows.Forms.Padding(2);
            this.TXTBEDNAME.Name = "TXTBEDNAME";
            this.TXTBEDNAME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTBEDNAME.Size = new System.Drawing.Size(202, 26);
            this.TXTBEDNAME.TabIndex = 0;
            this.TXTBEDNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(214, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = ":تسلسل السرير";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(304, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1, 323);
            this.panel9.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(645, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel10.Location = new System.Drawing.Point(598, 563);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(150, 2);
            this.panel10.TabIndex = 9;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel11.Location = new System.Drawing.Point(592, 525);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 81);
            this.panel11.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(2, 446);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(647, 2);
            this.panel12.TabIndex = 7;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(2, 448);
            this.panel13.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel14, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel15, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.panel16, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.696429F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.50893F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.750973F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(649, 448);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(2, 32);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(645, 1);
            this.panel14.TabIndex = 3;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(2, 437);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(645, 1);
            this.panel15.TabIndex = 4;
            // 
            // panel16
            // 
            this.panel16.AutoScroll = true;
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Controls.Add(this.pic_exit);
            this.panel16.Controls.Add(this.label8);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(2, 2);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(645, 26);
            this.panel16.TabIndex = 5;
            // 
            // pic_exit
            // 
            this.pic_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_exit.Image")));
            this.pic_exit.Location = new System.Drawing.Point(607, 0);
            this.pic_exit.Margin = new System.Windows.Forms.Padding(2);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(38, 26);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_exit.TabIndex = 2;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Booking Screen";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 2);
            this.panel1.TabIndex = 8;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(647, 2);
            this.panel17.Margin = new System.Windows.Forms.Padding(2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(2, 444);
            this.panel17.TabIndex = 7;
            // 
            // gET_H_BED_NAME_CODEBindingSource
            // 
            this.gET_H_BED_NAME_CODEBindingSource.DataMember = "GET_H_BED_NAME_CODE";
            this.gET_H_BED_NAME_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // gET_H_BED_NAME_CODETableAdapter
            // 
            this.gET_H_BED_NAME_CODETableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Detail";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 35;
            // 
            // iDBEDDataGridViewTextBoxColumn
            // 
            this.iDBEDDataGridViewTextBoxColumn.DataPropertyName = "ID_BED";
            this.iDBEDDataGridViewTextBoxColumn.HeaderText = "ID_BED";
            this.iDBEDDataGridViewTextBoxColumn.Name = "iDBEDDataGridViewTextBoxColumn";
            this.iDBEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDBEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEBEDDataGridViewTextBoxColumn
            // 
            this.nAMEBEDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nAMEBEDDataGridViewTextBoxColumn.DataPropertyName = "NAME_BED";
            this.nAMEBEDDataGridViewTextBoxColumn.HeaderText = "السرير";
            this.nAMEBEDDataGridViewTextBoxColumn.Name = "nAMEBEDDataGridViewTextBoxColumn";
            // 
            // iDFLOORDataGridViewTextBoxColumn
            // 
            this.iDFLOORDataGridViewTextBoxColumn.DataPropertyName = "ID_FLOOR";
            this.iDFLOORDataGridViewTextBoxColumn.HeaderText = "ID_FLOOR";
            this.iDFLOORDataGridViewTextBoxColumn.Name = "iDFLOORDataGridViewTextBoxColumn";
            this.iDFLOORDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDROOMDataGridViewTextBoxColumn
            // 
            this.iDROOMDataGridViewTextBoxColumn.DataPropertyName = "ID_ROOM";
            this.iDROOMDataGridViewTextBoxColumn.HeaderText = "ID_ROOM";
            this.iDROOMDataGridViewTextBoxColumn.Name = "iDROOMDataGridViewTextBoxColumn";
            this.iDROOMDataGridViewTextBoxColumn.Visible = false;
            // 
            // pICBEDDataGridViewImageColumn
            // 
            this.pICBEDDataGridViewImageColumn.DataPropertyName = "PIC_BED";
            this.pICBEDDataGridViewImageColumn.HeaderText = "PIC_BED";
            this.pICBEDDataGridViewImageColumn.Name = "pICBEDDataGridViewImageColumn";
            this.pICBEDDataGridViewImageColumn.Visible = false;
            // 
            // sTATEBEDDataGridViewTextBoxColumn
            // 
            this.sTATEBEDDataGridViewTextBoxColumn.DataPropertyName = "STATE_BED";
            this.sTATEBEDDataGridViewTextBoxColumn.HeaderText = "STATE_BED";
            this.sTATEBEDDataGridViewTextBoxColumn.Name = "sTATEBEDDataGridViewTextBoxColumn";
            this.sTATEBEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tYPEBEDDataGridViewTextBoxColumn
            // 
            this.tYPEBEDDataGridViewTextBoxColumn.DataPropertyName = "TYPE_BED";
            this.tYPEBEDDataGridViewTextBoxColumn.HeaderText = "TYPE_BED";
            this.tYPEBEDDataGridViewTextBoxColumn.Name = "tYPEBEDDataGridViewTextBoxColumn";
            this.tYPEBEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCTIVEBEDDataGridViewTextBoxColumn
            // 
            this.aCTIVEBEDDataGridViewTextBoxColumn.DataPropertyName = "ACTIVE_BED";
            this.aCTIVEBEDDataGridViewTextBoxColumn.HeaderText = "ACTIVE_BED";
            this.aCTIVEBEDDataGridViewTextBoxColumn.Name = "aCTIVEBEDDataGridViewTextBoxColumn";
            this.aCTIVEBEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEROOMDataGridViewTextBoxColumn
            // 
            this.nAMEROOMDataGridViewTextBoxColumn.DataPropertyName = "NAME_ROOM";
            this.nAMEROOMDataGridViewTextBoxColumn.HeaderText = "الغرفة";
            this.nAMEROOMDataGridViewTextBoxColumn.Name = "nAMEROOMDataGridViewTextBoxColumn";
            // 
            // fLOORNAMEDataGridViewTextBoxColumn
            // 
            this.fLOORNAMEDataGridViewTextBoxColumn.DataPropertyName = "FLOOR_NAME";
            this.fLOORNAMEDataGridViewTextBoxColumn.HeaderText = "الطابق";
            this.fLOORNAMEDataGridViewTextBoxColumn.Name = "fLOORNAMEDataGridViewTextBoxColumn";
            // 
            // FRM_ADD_BEDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 448);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_ADD_BEDS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة سرير";
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_H_ROOM_BYFLOOR_NAME_CODEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_H_FLOORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_H_TYPBEDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_BED)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_H_BED_NAME_CODEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private BindingSource v_A_H_TYPBEDBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_H_TYPBEDTableAdapter v_A_H_TYPBEDTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingSource v_A_H_FLOORBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_H_FLOORTableAdapter v_A_H_FLOORTableAdapter;
        private BindingSource gET_H_ROOM_BYFLOOR_NAME_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_H_ROOM_BYFLOOR_NAME_CODETableAdapter gET_H_ROOM_BYFLOOR_NAME_CODETableAdapter;
        private ErrorProvider errorProvider1;
        private Panel panel17;
        private Panel panel1;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private PictureBox pic_exit;
        private Label label8;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel9;
        private Panel panel7;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button BTN_EDIT;
        private Button button4;
        private Button button5;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel8;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private TextBox textBox1;
        private GroupBox groupBox4;
        private Label label7;
        private Label label6;
        private ComboBox nAME_ROOMComboBox;
        private Label label5;
        private ComboBox fLOOR_NAMEComboBox;
        private Label label4;
        private ComboBox nAME_TYPE_BEDComboBox;
        private PictureBox PIC_BED;
        private TextBox TXTID;
        private Label label1;
        private TextBox TXTBEDNAME;
        private Label label2;
        private BindingSource gET_H_BED_NAME_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_H_BED_NAME_CODETableAdapter gET_H_BED_NAME_CODETableAdapter;
        private DataGridViewImageColumn Column1;
        private DataGridViewTextBoxColumn iDBEDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nAMEBEDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDFLOORDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDROOMDataGridViewTextBoxColumn;
        private DataGridViewImageColumn pICBEDDataGridViewImageColumn;
        private DataGridViewTextBoxColumn sTATEBEDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tYPEBEDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aCTIVEBEDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nAMEROOMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fLOORNAMEDataGridViewTextBoxColumn;
    }
}