
namespace MEDICALCLINIC.ACCOUNT
{
    partial class FRM_SHOW_ALLDEBIT_DETAILS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SHOW_ALLDEBIT_DETAILS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.dgvalldata = new System.Windows.Forms.DataGridView();
            this.gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_PERSON_DEBIT_DETAILS_FOR_DRTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drcreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientcreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalldata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(904, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 446);
            this.panel1.TabIndex = 11;
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
            this.panel3.Size = new System.Drawing.Size(904, 2);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 448);
            this.panel4.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 448);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 2);
            this.panel2.TabIndex = 12;
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
            // dgvalldata
            // 
            this.dgvalldata.AllowUserToAddRows = false;
            this.dgvalldata.AutoGenerateColumns = false;
            this.dgvalldata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvalldata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvalldata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.bNAMEDataGridViewTextBoxColumn,
            this.bCODEDataGridViewTextBoxColumn,
            this.drcodeDataGridViewTextBoxColumn,
            this.aCCOUNTNAMEDataGridViewTextBoxColumn,
            this.patientcodeDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.drcreditDataGridViewTextBoxColumn,
            this.patientcreditDataGridViewTextBoxColumn});
            this.dgvalldata.DataSource = this.gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRBindingSource;
            this.dgvalldata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvalldata.EnableHeadersVisualStyles = false;
            this.dgvalldata.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvalldata.Location = new System.Drawing.Point(3, 25);
            this.dgvalldata.MultiSelect = false;
            this.dgvalldata.Name = "dgvalldata";
            this.dgvalldata.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvalldata.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvalldata.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgvalldata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvalldata.Size = new System.Drawing.Size(900, 379);
            this.dgvalldata.TabIndex = 6;
            // 
            // gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRBindingSource
            // 
            this.gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRBindingSource.DataMember = "GET_ALL_PERSON_DEBIT_DETAILS_FOR_DR";
            this.gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.222222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.016062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.016062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.222222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 450);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 20);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(902, 1);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(127)))), ((int)(((byte)(201)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(2, 409);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(902, 1);
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
            this.panel7.Size = new System.Drawing.Size(902, 14);
            this.panel7.TabIndex = 5;
            // 
            // pic_exit
            // 
            this.pic_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_exit.Image = ((System.Drawing.Image)(resources.GetObject("pic_exit.Image")));
            this.pic_exit.Location = new System.Drawing.Point(864, 0);
            this.pic_exit.Margin = new System.Windows.Forms.Padding(2);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(38, 14);
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
            this.label1.Size = new System.Drawing.Size(246, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "تفاصيل الديون";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRTableAdapter
            // 
            this.gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BILL_NUMBER";
            this.dataGridViewTextBoxColumn4.HeaderText = "رقم الفاتورة ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BILL_DATE";
            this.dataGridViewTextBoxColumn5.HeaderText = "التاريخ ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BILL_DESC";
            this.dataGridViewTextBoxColumn6.HeaderText = "الوصف";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // bNAMEDataGridViewTextBoxColumn
            // 
            this.bNAMEDataGridViewTextBoxColumn.DataPropertyName = "B_NAME";
            this.bNAMEDataGridViewTextBoxColumn.HeaderText = "الحركة ";
            this.bNAMEDataGridViewTextBoxColumn.Name = "bNAMEDataGridViewTextBoxColumn";
            this.bNAMEDataGridViewTextBoxColumn.Width = 150;
            // 
            // bCODEDataGridViewTextBoxColumn
            // 
            this.bCODEDataGridViewTextBoxColumn.DataPropertyName = "B_CODE";
            this.bCODEDataGridViewTextBoxColumn.HeaderText = "B_CODE";
            this.bCODEDataGridViewTextBoxColumn.Name = "bCODEDataGridViewTextBoxColumn";
            this.bCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // drcodeDataGridViewTextBoxColumn
            // 
            this.drcodeDataGridViewTextBoxColumn.DataPropertyName = "dr_code";
            this.drcodeDataGridViewTextBoxColumn.HeaderText = "dr_code";
            this.drcodeDataGridViewTextBoxColumn.Name = "drcodeDataGridViewTextBoxColumn";
            this.drcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCCOUNTNAMEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_NAME";
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.HeaderText = "أسم الحساب";
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.Name = "aCCOUNTNAMEDataGridViewTextBoxColumn";
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientcodeDataGridViewTextBoxColumn
            // 
            this.patientcodeDataGridViewTextBoxColumn.DataPropertyName = "patient_code";
            this.patientcodeDataGridViewTextBoxColumn.HeaderText = "patient_code";
            this.patientcodeDataGridViewTextBoxColumn.Name = "patientcodeDataGridViewTextBoxColumn";
            this.patientcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_NAME";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "أسم الدكتور ";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.Visible = false;
            this.expr1DataGridViewTextBoxColumn.Width = 150;
            // 
            // drcreditDataGridViewTextBoxColumn
            // 
            this.drcreditDataGridViewTextBoxColumn.DataPropertyName = "drcredit";
            this.drcreditDataGridViewTextBoxColumn.HeaderText = "الديون";
            this.drcreditDataGridViewTextBoxColumn.Name = "drcreditDataGridViewTextBoxColumn";
            this.drcreditDataGridViewTextBoxColumn.Width = 120;
            // 
            // patientcreditDataGridViewTextBoxColumn
            // 
            this.patientcreditDataGridViewTextBoxColumn.DataPropertyName = "patientcredit";
            this.patientcreditDataGridViewTextBoxColumn.HeaderText = "المقبوض منه ";
            this.patientcreditDataGridViewTextBoxColumn.Name = "patientcreditDataGridViewTextBoxColumn";
            this.patientcreditDataGridViewTextBoxColumn.Width = 120;
            // 
            // FRM_SHOW_ALLDEBIT_DETAILS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_SHOW_ALLDEBIT_DETAILS";
            this.Text = "FRM_SHOW_ALLDEBIT_DETAILS";
            this.Load += new System.EventHandler(this.FRM_SHOW_ALLDEBIT_DETAILS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalldata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel2;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvalldata;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.PictureBox pic_exit;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDBOXDETAILSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDBOXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMODEBITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOCREDITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMODEBITIQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOCREDITIQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURRANCYCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURRANCYMOKAFEADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bALANCEUSADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTCODE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTFULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTPARENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPEACCOUNTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINALCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTCURRANCYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTLEVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aCCOUNTACTIVEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCOSTCENTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMECOSTCENTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTCODE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pARENTCOSTCANTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEVELCOSTCENTERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRANCHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTCOSTTYPEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTATECOSTDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDBOX1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLDESCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOVECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bOXACTIVEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRACHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCOSTCENTER1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNAME1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_PERSON_DEBIT_DETAILS_FOR_DRTableAdapter gET_ALL_PERSON_DEBIT_DETAILS_FOR_DRTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drcreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientcreditDataGridViewTextBoxColumn;
    }
}