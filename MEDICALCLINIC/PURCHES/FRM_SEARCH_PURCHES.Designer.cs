namespace MEDICALCLINIC.PURCHES
{
    partial class FRM_SEARCH_PURCHES
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
            System.Windows.Forms.Label CLIENT_CODELabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SEARCH_PURCHES));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.p_GET_PURCHES_TO_EDITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.p_GET_PURCHES_TO_EDITTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_PURCHES_TO_EDITTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.p_GET_PURCHES_DEATILS_BY_NUMBERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_PURCHES_DEATILS_BY_NUMBERTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_PURCHES_DEATILS_BY_NUMBERTableAdapter();
            this.iDPURCHESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEPURCHESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTNAMEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALPAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALREMAINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPLIERCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOCTORCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_PURCHES_TO_EDITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_PURCHES_DEATILS_BY_NUMBERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.AutoSize = true;
            CLIENT_CODELabel.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.Location = new System.Drawing.Point(484, 22);
            CLIENT_CODELabel.Name = "CLIENT_CODELabel";
            CLIENT_CODELabel.Size = new System.Drawing.Size(59, 22);
            CLIENT_CODELabel.TabIndex = 57;
            CLIENT_CODELabel.Text = "البحث ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.TXT_SEARCH);
            this.groupBox1.Controls.Add(CLIENT_CODELabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_SEARCH.Location = new System.Drawing.Point(70, 19);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(408, 28);
            this.TXT_SEARCH.TabIndex = 58;
            this.TXT_SEARCH.TextChanged += new System.EventHandler(this.TXT_SEARCH_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(0, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(617, 423);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPURCHESDataGridViewTextBoxColumn,
            this.dATEPURCHESDataGridViewTextBoxColumn,
            this.cLIENTNAMEARDataGridViewTextBoxColumn,
            this.dOCTORNAMEDataGridViewTextBoxColumn,
            this.tOTALAMOUNTDataGridViewTextBoxColumn,
            this.tOTALPAIDDataGridViewTextBoxColumn,
            this.tOTALREMAINDataGridViewTextBoxColumn,
            this.sUPPLIERCODEDataGridViewTextBoxColumn,
            this.dOCTORCODEDataGridViewTextBoxColumn,
            this.uSERCODEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.p_GET_PURCHES_TO_EDITBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 21);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(611, 399);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // p_GET_PURCHES_TO_EDITBindingSource
            // 
            this.p_GET_PURCHES_TO_EDITBindingSource.DataMember = "P_GET_PURCHES_TO_EDIT";
            this.p_GET_PURCHES_TO_EDITBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.Locale = new System.Globalization.CultureInfo("ar-IQ");
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.buttonX3);
            this.groupBox3.Controls.Add(this.buttonX4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(617, 95);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX3.Font = new System.Drawing.Font("STV", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX3.Image = ((System.Drawing.Image)(resources.GetObject("buttonX3.Image")));
            this.buttonX3.Location = new System.Drawing.Point(306, 12);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(25, 0, 2, 25);
            this.buttonX3.Size = new System.Drawing.Size(246, 73);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.TabIndex = 1;
            this.buttonX3.Text = "Details";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonX4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX4.Font = new System.Drawing.Font("STV", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX4.Image = ((System.Drawing.Image)(resources.GetObject("buttonX4.Image")));
            this.buttonX4.Location = new System.Drawing.Point(54, 12);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(25, 0, 2, 25);
            this.buttonX4.Size = new System.Drawing.Size(233, 73);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.TabIndex = 5;
            this.buttonX4.Text = "Exit";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // p_GET_PURCHES_TO_EDITTableAdapter
            // 
            this.p_GET_PURCHES_TO_EDITTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.T_DRAGE_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_DRAGETableAdapter = null;
            this.tableAdapterManager.T_GROUP_DOCTORTableAdapter = null;
            this.tableAdapterManager.T_IMAGETableAdapter = null;
            this.tableAdapterManager.T_IMG_PERSTableAdapter = null;
            this.tableAdapterManager.T_ITEMSTableAdapter = null;
            this.tableAdapterManager.T_MAJORTableAdapter = null;
            this.tableAdapterManager.T_ORDER_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_ORDERTableAdapter = null;
            this.tableAdapterManager.T_PERSONTableAdapter = null;
            this.tableAdapterManager.T_PURCHES_DETAILSTableAdapter = null;
            this.tableAdapterManager.T_PURCHESTableAdapter = null;
            this.tableAdapterManager.T_SEX_STATETableAdapter = null;
            this.tableAdapterManager.T_STATETableAdapter = null;
            this.tableAdapterManager.T_TOOTH_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_TRATMENT_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_TYPE_MOVETableAdapter = null;
            this.tableAdapterManager.T_TYPE_PAYTableAdapter = null;
            
            this.tableAdapterManager.T_USERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // p_GET_PURCHES_DEATILS_BY_NUMBERBindingSource
            // 
            this.p_GET_PURCHES_DEATILS_BY_NUMBERBindingSource.DataMember = "P_GET_PURCHES_DEATILS_BY_NUMBER";
            this.p_GET_PURCHES_DEATILS_BY_NUMBERBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_PURCHES_DEATILS_BY_NUMBERTableAdapter
            // 
            this.p_GET_PURCHES_DEATILS_BY_NUMBERTableAdapter.ClearBeforeFill = true;
            // 
            // iDPURCHESDataGridViewTextBoxColumn
            // 
            this.iDPURCHESDataGridViewTextBoxColumn.DataPropertyName = "ID_PURCHES";
            this.iDPURCHESDataGridViewTextBoxColumn.HeaderText = "رقم الفاتورة";
            this.iDPURCHESDataGridViewTextBoxColumn.Name = "iDPURCHESDataGridViewTextBoxColumn";
            this.iDPURCHESDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPURCHESDataGridViewTextBoxColumn.Width = 120;
            // 
            // dATEPURCHESDataGridViewTextBoxColumn
            // 
            this.dATEPURCHESDataGridViewTextBoxColumn.DataPropertyName = "DATE_PURCHES";
            this.dATEPURCHESDataGridViewTextBoxColumn.HeaderText = "تأريخ الفاتورة ";
            this.dATEPURCHESDataGridViewTextBoxColumn.Name = "dATEPURCHESDataGridViewTextBoxColumn";
            this.dATEPURCHESDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATEPURCHESDataGridViewTextBoxColumn.Width = 120;
            // 
            // cLIENTNAMEARDataGridViewTextBoxColumn
            // 
            this.cLIENTNAMEARDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cLIENTNAMEARDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NAME_AR";
            this.cLIENTNAMEARDataGridViewTextBoxColumn.HeaderText = "أسم المجهز";
            this.cLIENTNAMEARDataGridViewTextBoxColumn.Name = "cLIENTNAMEARDataGridViewTextBoxColumn";
            this.cLIENTNAMEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOCTORNAMEDataGridViewTextBoxColumn
            // 
            this.dOCTORNAMEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_NAME";
            this.dOCTORNAMEDataGridViewTextBoxColumn.HeaderText = "أسم الدكتور";
            this.dOCTORNAMEDataGridViewTextBoxColumn.Name = "dOCTORNAMEDataGridViewTextBoxColumn";
            this.dOCTORNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOCTORNAMEDataGridViewTextBoxColumn.Width = 160;
            // 
            // tOTALAMOUNTDataGridViewTextBoxColumn
            // 
            this.tOTALAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_AMOUNT";
            this.tOTALAMOUNTDataGridViewTextBoxColumn.HeaderText = "TOTAL_AMO";
            this.tOTALAMOUNTDataGridViewTextBoxColumn.Name = "tOTALAMOUNTDataGridViewTextBoxColumn";
            this.tOTALAMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALAMOUNTDataGridViewTextBoxColumn.Visible = false;
            // 
            // tOTALPAIDDataGridViewTextBoxColumn
            // 
            this.tOTALPAIDDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_PAID";
            this.tOTALPAIDDataGridViewTextBoxColumn.HeaderText = "TOTAL_PAID";
            this.tOTALPAIDDataGridViewTextBoxColumn.Name = "tOTALPAIDDataGridViewTextBoxColumn";
            this.tOTALPAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALPAIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tOTALREMAINDataGridViewTextBoxColumn
            // 
            this.tOTALREMAINDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_REMAIN";
            this.tOTALREMAINDataGridViewTextBoxColumn.HeaderText = "TOTAL_REMAIN";
            this.tOTALREMAINDataGridViewTextBoxColumn.Name = "tOTALREMAINDataGridViewTextBoxColumn";
            this.tOTALREMAINDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALREMAINDataGridViewTextBoxColumn.Visible = false;
            // 
            // sUPPLIERCODEDataGridViewTextBoxColumn
            // 
            this.sUPPLIERCODEDataGridViewTextBoxColumn.DataPropertyName = "SUPPLIER_CODE";
            this.sUPPLIERCODEDataGridViewTextBoxColumn.HeaderText = "SUPPLIER_CODE";
            this.sUPPLIERCODEDataGridViewTextBoxColumn.Name = "sUPPLIERCODEDataGridViewTextBoxColumn";
            this.sUPPLIERCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUPPLIERCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // dOCTORCODEDataGridViewTextBoxColumn
            // 
            this.dOCTORCODEDataGridViewTextBoxColumn.DataPropertyName = "DOCTOR_CODE";
            this.dOCTORCODEDataGridViewTextBoxColumn.HeaderText = "DOCTOR_CODE";
            this.dOCTORCODEDataGridViewTextBoxColumn.Name = "dOCTORCODEDataGridViewTextBoxColumn";
            this.dOCTORCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOCTORCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // uSERCODEDataGridViewTextBoxColumn
            // 
            this.uSERCODEDataGridViewTextBoxColumn.DataPropertyName = "USER_CODE";
            this.uSERCODEDataGridViewTextBoxColumn.HeaderText = "USER_CODE";
            this.uSERCODEDataGridViewTextBoxColumn.Name = "uSERCODEDataGridViewTextBoxColumn";
            this.uSERCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERCODEDataGridViewTextBoxColumn.Visible = false;
            // 
            // FRM_SEARCH_PURCHES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "FRM_SEARCH_PURCHES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث عن المشتريات";
            this.Load += new System.EventHandler(this.FRM_SEARCH_SANAD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_PURCHES_TO_EDITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_PURCHES_DEATILS_BY_NUMBERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.TextBox TXT_SEARCH;
        public System.Windows.Forms.DataGridView dataGridView2;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource p_GET_PURCHES_TO_EDITBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_PURCHES_TO_EDITTableAdapter p_GET_PURCHES_TO_EDITTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource p_GET_PURCHES_DEATILS_BY_NUMBERBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_PURCHES_DEATILS_BY_NUMBERTableAdapter p_GET_PURCHES_DEATILS_BY_NUMBERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPURCHESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEPURCHESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTNAMEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALPAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALREMAINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPLIERCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOCTORCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERCODEDataGridViewTextBoxColumn;
    }
}