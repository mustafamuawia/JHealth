namespace MEDICALCLINIC.DIAGNOSES
{
    partial class LAST_BOOKING_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAST_BOOKING_UC));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bOOKINGCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOOTHNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAINCLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRAETMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRAGENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.p_GET_TOOTH_BOOKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.p_GET_TOOTH_BOOKINGTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_TOOTH_BOOKINGTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.p_GET_IMG_BY_CODE_BOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_IMG_BY_CODE_BOOKTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_IMG_BY_CODE_BOOKTableAdapter();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_TOOTH_BOOKINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_IMG_BY_CODE_BOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 289);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(1071, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 33);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1117, 249);
            this.tableLayoutPanel4.TabIndex = 6;
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
            this.bOOKINGCODEDataGridViewTextBoxColumn,
            this.tOOTHNAMEDataGridViewTextBoxColumn,
            this.pAINCLASSDataGridViewTextBoxColumn,
            this.tRAETMENTDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn,
            this.dRAGENAMEDataGridViewTextBoxColumn,
            this.pERSONCODEDataGridViewTextBoxColumn,
            this.dOCTORCODEDataGridViewTextBoxColumn,
            this.Column1});
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
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1109, 241);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // bOOKINGCODEDataGridViewTextBoxColumn
            // 
            this.bOOKINGCODEDataGridViewTextBoxColumn.DataPropertyName = "BOOKING_CODE";
            this.bOOKINGCODEDataGridViewTextBoxColumn.HeaderText = "NO.";
            this.bOOKINGCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bOOKINGCODEDataGridViewTextBoxColumn.Name = "bOOKINGCODEDataGridViewTextBoxColumn";
            this.bOOKINGCODEDataGridViewTextBoxColumn.Width = 80;
            // 
            // tOOTHNAMEDataGridViewTextBoxColumn
            // 
            this.tOOTHNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tOOTHNAMEDataGridViewTextBoxColumn.DataPropertyName = "TOOTH_NAME";
            this.tOOTHNAMEDataGridViewTextBoxColumn.HeaderText = "Tooth No ";
            this.tOOTHNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tOOTHNAMEDataGridViewTextBoxColumn.Name = "tOOTHNAMEDataGridViewTextBoxColumn";
            // 
            // pAINCLASSDataGridViewTextBoxColumn
            // 
            this.pAINCLASSDataGridViewTextBoxColumn.DataPropertyName = "PAIN_CLASS";
            this.pAINCLASSDataGridViewTextBoxColumn.HeaderText = "Class";
            this.pAINCLASSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pAINCLASSDataGridViewTextBoxColumn.Name = "pAINCLASSDataGridViewTextBoxColumn";
            this.pAINCLASSDataGridViewTextBoxColumn.Width = 230;
            // 
            // tRAETMENTDataGridViewTextBoxColumn
            // 
            this.tRAETMENTDataGridViewTextBoxColumn.DataPropertyName = "TRAETMENT";
            this.tRAETMENTDataGridViewTextBoxColumn.HeaderText = "Treatment";
            this.tRAETMENTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tRAETMENTDataGridViewTextBoxColumn.Name = "tRAETMENTDataGridViewTextBoxColumn";
            this.tRAETMENTDataGridViewTextBoxColumn.Width = 230;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "Price";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dRAGENAMEDataGridViewTextBoxColumn
            // 
            this.dRAGENAMEDataGridViewTextBoxColumn.DataPropertyName = "DRAGE_NAME";
            this.dRAGENAMEDataGridViewTextBoxColumn.HeaderText = "DRAGE_NAME";
            this.dRAGENAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dRAGENAMEDataGridViewTextBoxColumn.Name = "dRAGENAMEDataGridViewTextBoxColumn";
            this.dRAGENAMEDataGridViewTextBoxColumn.Visible = false;
            this.dRAGENAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pERSONCODEDataGridViewTextBoxColumn
            // 
            this.pERSONCODEDataGridViewTextBoxColumn.DataPropertyName = "PERSON_CODE";
            this.pERSONCODEDataGridViewTextBoxColumn.HeaderText = "PERSON_CODE";
            this.pERSONCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONCODEDataGridViewTextBoxColumn.Name = "pERSONCODEDataGridViewTextBoxColumn";
            this.pERSONCODEDataGridViewTextBoxColumn.Visible = false;
            this.pERSONCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOCTORCODEDataGridViewTextBoxColumn
            // 
            this.dOCTORCODEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_CODE";
            this.dOCTORCODEDataGridViewTextBoxColumn.HeaderText = "DOCTOR_CODE";
            this.dOCTORCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOCTORCODEDataGridViewTextBoxColumn.Name = "dOCTORCODEDataGridViewTextBoxColumn";
            this.dOCTORCODEDataGridViewTextBoxColumn.Visible = false;
            this.dOCTORCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BOOKING_CODE";
            this.Column1.HeaderText = " Image";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Text = " Image";
            this.Column1.ToolTipText = " Image";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 90;
            // 
            // p_GET_TOOTH_BOOKINGBindingSource
            // 
            this.p_GET_TOOTH_BOOKINGBindingSource.DataMember = "P_GET_TOOTH_BOOKING";
            this.p_GET_TOOTH_BOOKINGBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.Locale = new System.Globalization.CultureInfo("ar-IQ");
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_GET_TOOTH_BOOKINGTableAdapter
            // 
            this.p_GET_TOOTH_BOOKINGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.T_ACCOUNT_TYPETableAdapter = null;
            this.tableAdapterManager.T_ACCOUNTSTableAdapter = null;
            this.tableAdapterManager.T_BILL_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOK_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_BOX_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_BOXTableAdapter = null;
            this.tableAdapterManager.T_CASH_DEBTTableAdapter = null;
            this.tableAdapterManager.T_CATEGORIESTableAdapter = null;
            this.tableAdapterManager.T_CLASS_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_CLIENT_TYPETableAdapter = null;
            this.tableAdapterManager.T_CLIENTTableAdapter = null;
            this.tableAdapterManager.T_CURRANNCYTableAdapter = null;
            this.tableAdapterManager.T_DESCRPTIONTableAdapter = null;
            this.tableAdapterManager.T_DISEASETableAdapter = null;
            this.tableAdapterManager.T_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_DRAGE_GROUPTableAdapter = null;
            this.tableAdapterManager.T_DRAGE_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_DRAGETableAdapter = null;
            this.tableAdapterManager.T_GROUP_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_IMAGETableAdapter = null;
            this.tableAdapterManager.T_IMG_PERSTableAdapter = null;
            this.tableAdapterManager.T_ITEMSTableAdapter = null;
            this.tableAdapterManager.T_L_CAETGORESTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTRAYDETAILSTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTRAYTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTTESTDETAILSTableAdapter = null;
            this.tableAdapterManager.T_L_RESULTTESTTableAdapter = null;
            this.tableAdapterManager.T_L_TESTSTableAdapter = null;
            this.tableAdapterManager.T_L_UNITTableAdapter = null;
            this.tableAdapterManager.T_LAB_NAMETableAdapter = null;
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
            
            this.tableAdapterManager.T_SEX_STATETableAdapter = null;
            this.tableAdapterManager.T_STATETableAdapter = null;
            this.tableAdapterManager.T_TOOTH_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_TRATMENT_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_TYPE_MOVETableAdapter = null;
            this.tableAdapterManager.T_TYPE_PAYTableAdapter = null;
          
           // 
          //  this.tableAdapterManager.T_USERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // LAST_BOOKING_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LAST_BOOKING_UC";
            this.Size = new System.Drawing.Size(1117, 289);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_TOOTH_BOOKINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_IMG_BY_CODE_BOOKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource p_GET_TOOTH_BOOKINGBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_TOOTH_BOOKINGTableAdapter p_GET_TOOTH_BOOKINGTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource p_GET_IMG_BY_CODE_BOOKBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_IMG_BY_CODE_BOOKTableAdapter p_GET_IMG_BY_CODE_BOOKTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKINGCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOOTHNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAINCLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAETMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRAGENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}
