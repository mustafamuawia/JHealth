﻿namespace MEDICALCLINIC.SANAD
{
    partial class FRM_SEARCH_ACCOUNT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_SEARCH_ACCOUNT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.aCCOUNTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTPARENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTLEVELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bALANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bALANCEIQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gET_ALL_ACCOUNT_FRO_TOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.gET_DOCTOR_NAME_CODEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.p_BOX_ALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_BOX_ALLTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.gET_ALL_ACCOUNT_FRO_TOTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_ACCOUNT_FRO_TOTableAdapter();
            this.gET_DOCTOR_NAME_CODETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_DOCTOR_NAME_CODETableAdapter();
            this.BTN_DETAILS = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_ACCOUNT_FRO_TOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_DOCTOR_NAME_CODEBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOX_ALLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.AutoSize = true;
            CLIENT_CODELabel.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.Location = new System.Drawing.Point(410, 21);
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
            this.groupBox1.Size = new System.Drawing.Size(511, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
           
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXT_SEARCH.Location = new System.Drawing.Point(49, 18);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(355, 28);
            this.TXT_SEARCH.TabIndex = 58;
            this.TXT_SEARCH.TextChanged += new System.EventHandler(this.TXT_SEARCH_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(511, 429);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCCOUNTCODEDataGridViewTextBoxColumn,
            this.aCCOUNTNAMEDataGridViewTextBoxColumn,
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn,
            this.aCCOUNTPARENTDataGridViewTextBoxColumn,
            this.aCCOUNTLEVELDataGridViewTextBoxColumn,
            this.bALANCEDataGridViewTextBoxColumn,
            this.bALANCEIQDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.gET_ALL_ACCOUNT_FRO_TOBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(505, 410);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // aCCOUNTCODEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTCODEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_CODE";
            this.aCCOUNTCODEDataGridViewTextBoxColumn.HeaderText = "كود الحساب";
            this.aCCOUNTCODEDataGridViewTextBoxColumn.Name = "aCCOUNTCODEDataGridViewTextBoxColumn";
            this.aCCOUNTCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTCODEDataGridViewTextBoxColumn.Width = 150;
            // 
            // aCCOUNTNAMEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_NAME";
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.HeaderText = "أسم الحساب";
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.Name = "aCCOUNTNAMEDataGridViewTextBoxColumn";
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCCOUNTFULLNAMEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_FULL_NAME";
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.HeaderText = "أسم الحساب";
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.Name = "aCCOUNTFULLNAMEDataGridViewTextBoxColumn";
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aCCOUNTPARENTDataGridViewTextBoxColumn
            // 
            this.aCCOUNTPARENTDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_PARENT";
            this.aCCOUNTPARENTDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_PARENT";
            this.aCCOUNTPARENTDataGridViewTextBoxColumn.Name = "aCCOUNTPARENTDataGridViewTextBoxColumn";
            this.aCCOUNTPARENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTPARENTDataGridViewTextBoxColumn.Visible = false;
            // 
            // aCCOUNTLEVELDataGridViewTextBoxColumn
            // 
            this.aCCOUNTLEVELDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_LEVEL";
            this.aCCOUNTLEVELDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_LEVEL";
            this.aCCOUNTLEVELDataGridViewTextBoxColumn.Name = "aCCOUNTLEVELDataGridViewTextBoxColumn";
            this.aCCOUNTLEVELDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTLEVELDataGridViewTextBoxColumn.Visible = false;
            // 
            // bALANCEDataGridViewTextBoxColumn
            // 
            this.bALANCEDataGridViewTextBoxColumn.DataPropertyName = "BALANCE";
            this.bALANCEDataGridViewTextBoxColumn.HeaderText = "الرصيد $";
            this.bALANCEDataGridViewTextBoxColumn.Name = "bALANCEDataGridViewTextBoxColumn";
            this.bALANCEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bALANCEDataGridViewTextBoxColumn.Visible = false;
            // 
            // bALANCEIQDataGridViewTextBoxColumn
            // 
            this.bALANCEIQDataGridViewTextBoxColumn.DataPropertyName = "BALANCE_IQ";
            this.bALANCEIQDataGridViewTextBoxColumn.HeaderText = "الرصيد دينار";
            this.bALANCEIQDataGridViewTextBoxColumn.Name = "bALANCEIQDataGridViewTextBoxColumn";
            this.bALANCEIQDataGridViewTextBoxColumn.ReadOnly = true;
            this.bALANCEIQDataGridViewTextBoxColumn.Visible = false;
            this.bALANCEIQDataGridViewTextBoxColumn.Width = 150;
            // 
            // gET_ALL_ACCOUNT_FRO_TOBindingSource
            // 
            this.gET_ALL_ACCOUNT_FRO_TOBindingSource.DataMember = "GET_ALL_ACCOUNT_FRO_TO";
            this.gET_ALL_ACCOUNT_FRO_TOBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gET_DOCTOR_NAME_CODEBindingSource
            // 
            this.gET_DOCTOR_NAME_CODEBindingSource.DataMember = "GET_DOCTOR_NAME_CODE";
            this.gET_DOCTOR_NAME_CODEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.BTN_DETAILS);
            this.groupBox3.Controls.Add(this.BTN_EXIT);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 95);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // p_BOX_ALLBindingSource
            // 
            this.p_BOX_ALLBindingSource.DataMember = "P_BOX_ALL";
            this.p_BOX_ALLBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_BOX_ALLTableAdapter
            // 
            this.p_BOX_ALLTableAdapter.ClearBeforeFill = true;
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
            // gET_ALL_ACCOUNT_FRO_TOTableAdapter
            // 
            this.gET_ALL_ACCOUNT_FRO_TOTableAdapter.ClearBeforeFill = true;
            // 
            // gET_DOCTOR_NAME_CODETableAdapter
            // 
            this.gET_DOCTOR_NAME_CODETableAdapter.ClearBeforeFill = true;
            // 
            // BTN_DETAILS
            // 
            this.BTN_DETAILS.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_DETAILS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DETAILS.Font = new System.Drawing.Font("STV", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_DETAILS.ForeColor = System.Drawing.Color.White;
            this.BTN_DETAILS.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DETAILS.Image")));
            this.BTN_DETAILS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DETAILS.Location = new System.Drawing.Point(269, 16);
            this.BTN_DETAILS.Name = "BTN_DETAILS";
            this.BTN_DETAILS.Size = new System.Drawing.Size(218, 73);
            this.BTN_DETAILS.TabIndex = 136;
            this.BTN_DETAILS.Text = "تفاصيل";
            this.BTN_DETAILS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_DETAILS.UseVisualStyleBackColor = false;
            this.BTN_DETAILS.Click += new System.EventHandler(this.BTN_DETAILS_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.BackColor = System.Drawing.Color.Red;
            this.BTN_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXIT.Font = new System.Drawing.Font("STV", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EXIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_EXIT.Image")));
            this.BTN_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EXIT.Location = new System.Drawing.Point(19, 16);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(169, 73);
            this.BTN_EXIT.TabIndex = 137;
            this.BTN_EXIT.Text = "خروج";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // FRM_SEARCH_ACCOUNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "FRM_SEARCH_ACCOUNT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_SEARCH_SANAD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_ALL_ACCOUNT_FRO_TOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_DOCTOR_NAME_CODEBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOX_ALLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TXT_SEARCH;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource p_BOX_ALLBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter p_BOX_ALLTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource gET_ALL_ACCOUNT_FRO_TOBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_ALL_ACCOUNT_FRO_TOTableAdapter gET_ALL_ACCOUNT_FRO_TOTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource gET_DOCTOR_NAME_CODEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_DOCTOR_NAME_CODETableAdapter gET_DOCTOR_NAME_CODETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTFULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTPARENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTLEVELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bALANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bALANCEIQDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTN_DETAILS;
        private System.Windows.Forms.Button BTN_EXIT;
    }
}