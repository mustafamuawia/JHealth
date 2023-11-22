namespace MEDICALCLINIC.DIAGNOSES
{
    partial class FRM_SHOW_TOOTH_DETAILS_BOOK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.p_GET_IMG_BY_CODE_BOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_IMG_BY_CODE_BOOKTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_IMG_BY_CODE_BOOKTableAdapter();
            this.p_GET_TOOTH_BOOKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_TOOTH_BOOKINGTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_TOOTH_BOOKINGTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bOOKINGCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOOTHNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAINCLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAETMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAETMENT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAETMENT3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAETMENT4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRAGENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEISCOMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_IMG_BY_CODE_BOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_TOOTH_BOOKINGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.T_BOOKING_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_BOX_DETAILS_T_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_BOX_DETAILS_TTableAdapter = null;
            this.tableAdapterManager.T_BOX_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_BOX_T_HISTORYTableAdapter = null;
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
            this.tableAdapterManager.T_QNTY_DRAGETableAdapter = null;
            this.tableAdapterManager.T_RAY_NAMETableAdapter = null;
            this.tableAdapterManager.T_RAYROOM_NAMETableAdapter = null;
            this.tableAdapterManager.T_REGION_TYPETableAdapter = null;
            this.tableAdapterManager.T_REGIONS_BODYTableAdapter = null;
            this.tableAdapterManager.T_RPT_IMG_LABTableAdapter = null;
            this.tableAdapterManager.T_RPT_IMGTableAdapter = null;
            this.tableAdapterManager.T_SEX_STATETableAdapter = null;
            this.tableAdapterManager.T_STATETableAdapter = null;
            this.tableAdapterManager.T_TIME_DRAGETableAdapter = null;
            this.tableAdapterManager.T_TOOTH_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_TRATMENT_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_TYPE_MOVETableAdapter = null;
            this.tableAdapterManager.T_TYPE_PAYTableAdapter = null;
            this.tableAdapterManager.T_USE_DRAGETableAdapter = null;
            this.tableAdapterManager.T_USERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.bOOKINGCODEDataGridViewTextBoxColumn,
            this.tOOTHNAMEDataGridViewTextBoxColumn,
            this.pAINCLASSDataGridViewTextBoxColumn,
            this.tRAETMENTDataGridViewTextBoxColumn,
            this.tRAETMENT2DataGridViewTextBoxColumn,
            this.tRAETMENT3DataGridViewTextBoxColumn,
            this.tRAETMENT4DataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.dRAGENAMEDataGridViewTextBoxColumn,
            this.pERSONCODEDataGridViewTextBoxColumn,
            this.dOCTORCODEDataGridViewTextBoxColumn,
            this.nOTICEDataGridViewTextBoxColumn,
            this.nAMEISCOMPDataGridViewTextBoxColumn});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView2.DataSource = this.p_GET_TOOTH_BOOKINGBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(779, 263);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(785, 269);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 269);
            this.panel3.TabIndex = 1;
            // 
            // p_GET_IMG_BY_CODE_BOOKBindingSource
            // 
            this.p_GET_IMG_BY_CODE_BOOKBindingSource.DataMember = "P_GET_IMG_BY_CODE_BOOK";
            this.p_GET_IMG_BY_CODE_BOOKBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_IMG_BY_CODE_BOOKTableAdapter
            // 
            this.p_GET_IMG_BY_CODE_BOOKTableAdapter.ClearBeforeFill = true;
            // 
            // p_GET_TOOTH_BOOKINGBindingSource
            // 
            this.p_GET_TOOTH_BOOKINGBindingSource.DataMember = "P_GET_TOOTH_BOOKING";
            this.p_GET_TOOTH_BOOKINGBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_TOOTH_BOOKINGTableAdapter
            // 
            this.p_GET_TOOTH_BOOKINGTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BOOKING_CODE";
            this.Column1.HeaderText = "IMG";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Text = "IMG";
            this.Column1.ToolTipText = "IMG";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 32;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BOOKING_CODE";
            this.Column2.HeaderText = "Not";
            this.Column2.Name = "Column2";
            this.Column2.Text = "Not";
            this.Column2.ToolTipText = "Not";
            this.Column2.UseColumnTextForButtonValue = true;
            this.Column2.Width = 32;
            // 
            // bOOKINGCODEDataGridViewTextBoxColumn
            // 
            this.bOOKINGCODEDataGridViewTextBoxColumn.DataPropertyName = "BOOKING_CODE";
            this.bOOKINGCODEDataGridViewTextBoxColumn.HeaderText = "BOOKING_CODE";
            this.bOOKINGCODEDataGridViewTextBoxColumn.Name = "bOOKINGCODEDataGridViewTextBoxColumn";
            this.bOOKINGCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // tOOTHNAMEDataGridViewTextBoxColumn
            // 
            this.tOOTHNAMEDataGridViewTextBoxColumn.DataPropertyName = "TOOTH_NAME";
            this.tOOTHNAMEDataGridViewTextBoxColumn.HeaderText = "Tooth No";
            this.tOOTHNAMEDataGridViewTextBoxColumn.Name = "tOOTHNAMEDataGridViewTextBoxColumn";
            // 
            // pAINCLASSDataGridViewTextBoxColumn
            // 
            this.pAINCLASSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pAINCLASSDataGridViewTextBoxColumn.DataPropertyName = "PAIN_CLASS";
            this.pAINCLASSDataGridViewTextBoxColumn.HeaderText = "Procedure";
            this.pAINCLASSDataGridViewTextBoxColumn.Name = "pAINCLASSDataGridViewTextBoxColumn";
            // 
            // tRAETMENTDataGridViewTextBoxColumn
            // 
            this.tRAETMENTDataGridViewTextBoxColumn.DataPropertyName = "TRAETMENT";
            this.tRAETMENTDataGridViewTextBoxColumn.HeaderText = "Treatmnet1";
            this.tRAETMENTDataGridViewTextBoxColumn.Name = "tRAETMENTDataGridViewTextBoxColumn";
            // 
            // tRAETMENT2DataGridViewTextBoxColumn
            // 
            this.tRAETMENT2DataGridViewTextBoxColumn.DataPropertyName = "TRAETMENT2";
            this.tRAETMENT2DataGridViewTextBoxColumn.HeaderText = "Treatmnet2";
            this.tRAETMENT2DataGridViewTextBoxColumn.Name = "tRAETMENT2DataGridViewTextBoxColumn";
            // 
            // tRAETMENT3DataGridViewTextBoxColumn
            // 
            this.tRAETMENT3DataGridViewTextBoxColumn.DataPropertyName = "TRAETMENT3";
            this.tRAETMENT3DataGridViewTextBoxColumn.HeaderText = "Treatmnet3";
            this.tRAETMENT3DataGridViewTextBoxColumn.Name = "tRAETMENT3DataGridViewTextBoxColumn";
            // 
            // tRAETMENT4DataGridViewTextBoxColumn
            // 
            this.tRAETMENT4DataGridViewTextBoxColumn.DataPropertyName = "TRAETMENT4";
            this.tRAETMENT4DataGridViewTextBoxColumn.HeaderText = "TRAETMENT4";
            this.tRAETMENT4DataGridViewTextBoxColumn.Name = "tRAETMENT4DataGridViewTextBoxColumn";
            this.tRAETMENT4DataGridViewTextBoxColumn.Visible = false;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "Price";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            // 
            // dRAGENAMEDataGridViewTextBoxColumn
            // 
            this.dRAGENAMEDataGridViewTextBoxColumn.DataPropertyName = "DRAGE_NAME";
            this.dRAGENAMEDataGridViewTextBoxColumn.HeaderText = "DRAGE_NAME";
            this.dRAGENAMEDataGridViewTextBoxColumn.Name = "dRAGENAMEDataGridViewTextBoxColumn";
            this.dRAGENAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pERSONCODEDataGridViewTextBoxColumn
            // 
            this.pERSONCODEDataGridViewTextBoxColumn.DataPropertyName = "PERSON_CODE";
            this.pERSONCODEDataGridViewTextBoxColumn.HeaderText = "PERSON_CODE";
            this.pERSONCODEDataGridViewTextBoxColumn.Name = "pERSONCODEDataGridViewTextBoxColumn";
            this.pERSONCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // dOCTORCODEDataGridViewTextBoxColumn
            // 
            this.dOCTORCODEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_CODE";
            this.dOCTORCODEDataGridViewTextBoxColumn.HeaderText = "DOCTOR_CODE";
            this.dOCTORCODEDataGridViewTextBoxColumn.Name = "dOCTORCODEDataGridViewTextBoxColumn";
            this.dOCTORCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOTICEDataGridViewTextBoxColumn
            // 
            this.nOTICEDataGridViewTextBoxColumn.DataPropertyName = "NOTICE";
            this.nOTICEDataGridViewTextBoxColumn.HeaderText = "NOTICE";
            this.nOTICEDataGridViewTextBoxColumn.Name = "nOTICEDataGridViewTextBoxColumn";
            this.nOTICEDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEISCOMPDataGridViewTextBoxColumn
            // 
            this.nAMEISCOMPDataGridViewTextBoxColumn.DataPropertyName = "NAME_IS_COMP";
            this.nAMEISCOMPDataGridViewTextBoxColumn.HeaderText = "NAME_IS_COMP";
            this.nAMEISCOMPDataGridViewTextBoxColumn.Name = "nAMEISCOMPDataGridViewTextBoxColumn";
            this.nAMEISCOMPDataGridViewTextBoxColumn.Visible = false;
            // 
            // FRM_SHOW_TOOTH_DETAILS_BOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(785, 269);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SHOW_TOOTH_DETAILS_BOOK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_SHOW_TOOTH_DETAILS_BOOK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_IMG_BY_CODE_BOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_TOOTH_BOOKINGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource p_GET_IMG_BY_CODE_BOOKBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_IMG_BY_CODE_BOOKTableAdapter p_GET_IMG_BY_CODE_BOOKTableAdapter;
        private System.Windows.Forms.BindingSource p_GET_TOOTH_BOOKINGBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_TOOTH_BOOKINGTableAdapter p_GET_TOOTH_BOOKINGTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKINGCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOOTHNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAINCLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAETMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAETMENT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAETMENT3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAETMENT4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRAGENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEISCOMPDataGridViewTextBoxColumn;
    }
}

