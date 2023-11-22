
namespace MEDICALCLINIC.XRAY.REPORT
{
    partial class FRM_XRY_REPORT_DETAILS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_XRY_REPORT_DETAILS));
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvalldata = new System.Windows.Forms.DataGridView();
            this.p_GET_L_ALL_XRAY_REPORT_DETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p_GET_L_ALL_XRAY_REPORT_DETTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_L_ALL_XRAY_REPORT_DETTableAdapter();
            this.pERSONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMERAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bODYAREADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOLORTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSCOMPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDRAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalldata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_L_ALL_XRAY_REPORT_DETBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            this.SuspendLayout();
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
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 2);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 413);
            this.panel4.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 413);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 2);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(798, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 415);
            this.panel1.TabIndex = 11;
            // 
            // dgvalldata
            // 
            this.dgvalldata.AllowUserToAddRows = false;
            this.dgvalldata.AutoGenerateColumns = false;
            this.dgvalldata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvalldata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvalldata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pERSONNAMEDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn,
            this.sEXNAMEDataGridViewTextBoxColumn,
            this.dOCTORNAMEDataGridViewTextBoxColumn,
            this.nAMERAYDataGridViewTextBoxColumn,
            this.bODYAREADataGridViewTextBoxColumn,
            this.hDIRDataGridViewTextBoxColumn,
            this.vDIRDataGridViewTextBoxColumn,
            this.cOLORTYPEDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.iSCOMPDataGridViewCheckBoxColumn,
            this.iDRAYDataGridViewTextBoxColumn});
            this.dgvalldata.DataSource = this.p_GET_L_ALL_XRAY_REPORT_DETBindingSource;
            this.dgvalldata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvalldata.EnableHeadersVisualStyles = false;
            this.dgvalldata.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvalldata.Location = new System.Drawing.Point(3, 28);
            this.dgvalldata.MultiSelect = false;
            this.dgvalldata.Name = "dgvalldata";
            this.dgvalldata.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvalldata.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvalldata.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvalldata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvalldata.Size = new System.Drawing.Size(794, 368);
            this.dgvalldata.TabIndex = 6;
            // 
            // p_GET_L_ALL_XRAY_REPORT_DETBindingSource
            // 
            this.p_GET_L_ALL_XRAY_REPORT_DETBindingSource.DataMember = "P_GET_L_ALL_XRAY_REPORT_DET";
            this.p_GET_L_ALL_XRAY_REPORT_DETBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvalldata, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.080312F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.016062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.42905F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.016062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.640264F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 415);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 23);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(796, 1);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(2, 401);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(796, 1);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.pic_exit);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(2, 2);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(796, 17);
            this.panel7.TabIndex = 5;
            // 
            // pic_exit
            // 
            this.pic_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_exit.Image")));
            this.pic_exit.Location = new System.Drawing.Point(758, 0);
            this.pic_exit.Margin = new System.Windows.Forms.Padding(2);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(38, 17);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_exit.TabIndex = 2;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "تفاصيل التحليل";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // p_GET_L_ALL_XRAY_REPORT_DETTableAdapter
            // 
            this.p_GET_L_ALL_XRAY_REPORT_DETTableAdapter.ClearBeforeFill = true;
            // 
            // pERSONNAMEDataGridViewTextBoxColumn
            // 
            this.pERSONNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pERSONNAMEDataGridViewTextBoxColumn.DataPropertyName = "PERSON_NAME";
            this.pERSONNAMEDataGridViewTextBoxColumn.HeaderText = "اسم المريض";
            this.pERSONNAMEDataGridViewTextBoxColumn.Name = "pERSONNAMEDataGridViewTextBoxColumn";
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "AGE";
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            this.aGEDataGridViewTextBoxColumn.Visible = false;
            // 
            // sEXNAMEDataGridViewTextBoxColumn
            // 
            this.sEXNAMEDataGridViewTextBoxColumn.DataPropertyName = "SEX_NAME";
            this.sEXNAMEDataGridViewTextBoxColumn.HeaderText = "SEX_NAME";
            this.sEXNAMEDataGridViewTextBoxColumn.Name = "sEXNAMEDataGridViewTextBoxColumn";
            this.sEXNAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // dOCTORNAMEDataGridViewTextBoxColumn
            // 
            this.dOCTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NAME";
            this.dOCTORNAMEDataGridViewTextBoxColumn.HeaderText = "الطبيب";
            this.dOCTORNAMEDataGridViewTextBoxColumn.Name = "dOCTORNAMEDataGridViewTextBoxColumn";
            this.dOCTORNAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMERAYDataGridViewTextBoxColumn
            // 
            this.nAMERAYDataGridViewTextBoxColumn.DataPropertyName = "NAME_RAY";
            this.nAMERAYDataGridViewTextBoxColumn.HeaderText = "الاشعة ";
            this.nAMERAYDataGridViewTextBoxColumn.Name = "nAMERAYDataGridViewTextBoxColumn";
            // 
            // bODYAREADataGridViewTextBoxColumn
            // 
            this.bODYAREADataGridViewTextBoxColumn.DataPropertyName = "BODY_AREA";
            this.bODYAREADataGridViewTextBoxColumn.HeaderText = "المنطقة ";
            this.bODYAREADataGridViewTextBoxColumn.Name = "bODYAREADataGridViewTextBoxColumn";
            // 
            // hDIRDataGridViewTextBoxColumn
            // 
            this.hDIRDataGridViewTextBoxColumn.DataPropertyName = "H_DIR";
            this.hDIRDataGridViewTextBoxColumn.HeaderText = "الاتجاة العمودي";
            this.hDIRDataGridViewTextBoxColumn.Name = "hDIRDataGridViewTextBoxColumn";
            // 
            // vDIRDataGridViewTextBoxColumn
            // 
            this.vDIRDataGridViewTextBoxColumn.DataPropertyName = "V_DIR";
            this.vDIRDataGridViewTextBoxColumn.HeaderText = "الافقي";
            this.vDIRDataGridViewTextBoxColumn.Name = "vDIRDataGridViewTextBoxColumn";
            // 
            // cOLORTYPEDataGridViewTextBoxColumn
            // 
            this.cOLORTYPEDataGridViewTextBoxColumn.DataPropertyName = "COLOR_TYPE";
            this.cOLORTYPEDataGridViewTextBoxColumn.HeaderText = "صبغة او بدون";
            this.cOLORTYPEDataGridViewTextBoxColumn.Name = "cOLORTYPEDataGridViewTextBoxColumn";
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "ملاحظات ";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            // 
            // iSCOMPDataGridViewCheckBoxColumn
            // 
            this.iSCOMPDataGridViewCheckBoxColumn.DataPropertyName = "IS_COMP";
            this.iSCOMPDataGridViewCheckBoxColumn.HeaderText = "متكملة ؟";
            this.iSCOMPDataGridViewCheckBoxColumn.Name = "iSCOMPDataGridViewCheckBoxColumn";
            // 
            // iDRAYDataGridViewTextBoxColumn
            // 
            this.iDRAYDataGridViewTextBoxColumn.DataPropertyName = "ID_RAY";
            this.iDRAYDataGridViewTextBoxColumn.HeaderText = "ID_RAY";
            this.iDRAYDataGridViewTextBoxColumn.Name = "iDRAYDataGridViewTextBoxColumn";
            this.iDRAYDataGridViewTextBoxColumn.Visible = false;
            // 
            // FRM_XRY_REPORT_DETAILS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_XRY_REPORT_DETAILS";
            this.Text = "FRM_XRY_REPORT_DETAILS";
            this.Load += new System.EventHandler(this.FRM_XRY_REPORT_DETAILS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalldata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_L_ALL_XRAY_REPORT_DETBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvalldata;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.PictureBox pic_exit;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource p_GET_L_ALL_XRAY_REPORT_DETBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_L_ALL_XRAY_REPORT_DETTableAdapter p_GET_L_ALL_XRAY_REPORT_DETTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMERAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bODYAREADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOLORTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iSCOMPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRAYDataGridViewTextBoxColumn;
    }
}