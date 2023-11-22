namespace MEDICALCLINIC.REPORT
{
    partial class FRM_R_PERSON_BORROW_DETAILS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.aCCOUNTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDBOXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILLNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bILLDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMODEBITIQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOCREDITIQDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gET_PERSON_BORROW_DETAILSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_DEBIT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_RECIVE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_REMAIN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_NAME = new System.Windows.Forms.Label();
            this.gET_PERSON_BORROW_DETAILSTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_PERSON_BORROW_DETAILSTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PERSON_BORROW_DETAILSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.39114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.60886F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 597);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCCOUNTCODEDataGridViewTextBoxColumn,
            this.aCCOUNTNAMEDataGridViewTextBoxColumn,
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn,
            this.tIDBOXDataGridViewTextBoxColumn,
            this.bILLNUMBERDataGridViewTextBoxColumn,
            this.bILLDATEDataGridViewTextBoxColumn,
            this.bNAMEDataGridViewTextBoxColumn,
            this.aMODEBITIQDataGridViewTextBoxColumn,
            this.aMOCREDITIQDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.gET_PERSON_BORROW_DETAILSBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(5, 83);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("STV", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(987, 456);
            this.dataGridView2.TabIndex = 3;
            // 
            // aCCOUNTCODEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTCODEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_CODE";
            this.aCCOUNTCODEDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_CODE";
            this.aCCOUNTCODEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCOUNTCODEDataGridViewTextBoxColumn.Name = "aCCOUNTCODEDataGridViewTextBoxColumn";
            this.aCCOUNTCODEDataGridViewTextBoxColumn.Visible = false;
            this.aCCOUNTCODEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCCOUNTNAMEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_NAME";
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.HeaderText = "ACCOUNT_NAME";
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.Name = "aCCOUNTNAMEDataGridViewTextBoxColumn";
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.Visible = false;
            this.aCCOUNTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aCCOUNTFULLNAMEDataGridViewTextBoxColumn
            // 
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT_FULL_NAME";
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.HeaderText = "الاسم الكامل";
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.Name = "aCCOUNTFULLNAMEDataGridViewTextBoxColumn";
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCCOUNTFULLNAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // tIDBOXDataGridViewTextBoxColumn
            // 
            this.tIDBOXDataGridViewTextBoxColumn.DataPropertyName = "T_ID_BOX";
            this.tIDBOXDataGridViewTextBoxColumn.HeaderText = "ت";
            this.tIDBOXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tIDBOXDataGridViewTextBoxColumn.Name = "tIDBOXDataGridViewTextBoxColumn";
            this.tIDBOXDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIDBOXDataGridViewTextBoxColumn.Width = 125;
            // 
            // bILLNUMBERDataGridViewTextBoxColumn
            // 
            this.bILLNUMBERDataGridViewTextBoxColumn.DataPropertyName = "BILL_NUMBER";
            this.bILLNUMBERDataGridViewTextBoxColumn.HeaderText = "الفاتورة";
            this.bILLNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bILLNUMBERDataGridViewTextBoxColumn.Name = "bILLNUMBERDataGridViewTextBoxColumn";
            this.bILLNUMBERDataGridViewTextBoxColumn.Width = 125;
            // 
            // bILLDATEDataGridViewTextBoxColumn
            // 
            this.bILLDATEDataGridViewTextBoxColumn.DataPropertyName = "BILL_DATE";
            this.bILLDATEDataGridViewTextBoxColumn.HeaderText = "التأريخ";
            this.bILLDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bILLDATEDataGridViewTextBoxColumn.Name = "bILLDATEDataGridViewTextBoxColumn";
            this.bILLDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // bNAMEDataGridViewTextBoxColumn
            // 
            this.bNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bNAMEDataGridViewTextBoxColumn.DataPropertyName = "B_NAME";
            this.bNAMEDataGridViewTextBoxColumn.HeaderText = "الحركة";
            this.bNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bNAMEDataGridViewTextBoxColumn.Name = "bNAMEDataGridViewTextBoxColumn";
            // 
            // aMODEBITIQDataGridViewTextBoxColumn
            // 
            this.aMODEBITIQDataGridViewTextBoxColumn.DataPropertyName = "AMO_DEBIT_IQ";
            this.aMODEBITIQDataGridViewTextBoxColumn.HeaderText = "الديون";
            this.aMODEBITIQDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aMODEBITIQDataGridViewTextBoxColumn.Name = "aMODEBITIQDataGridViewTextBoxColumn";
            this.aMODEBITIQDataGridViewTextBoxColumn.Width = 150;
            // 
            // aMOCREDITIQDataGridViewTextBoxColumn
            // 
            this.aMOCREDITIQDataGridViewTextBoxColumn.DataPropertyName = "AMO_CREDIT_IQ";
            this.aMOCREDITIQDataGridViewTextBoxColumn.HeaderText = "المستلمة";
            this.aMOCREDITIQDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aMOCREDITIQDataGridViewTextBoxColumn.Name = "aMOCREDITIQDataGridViewTextBoxColumn";
            this.aMOCREDITIQDataGridViewTextBoxColumn.Width = 150;
            // 
            // gET_PERSON_BORROW_DETAILSBindingSource
            // 
            this.gET_PERSON_BORROW_DETAILSBindingSource.DataMember = "GET_PERSON_BORROW_DETAILS";
            this.gET_PERSON_BORROW_DETAILSBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.Locale = new System.Globalization.CultureInfo("ar-IQ");
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.71521F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.28479F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel2.Controls.Add(this.LBL_DEBIT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.LBL_RECIVE, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.LBL_REMAIN, 7, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 547);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(989, 46);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // LBL_DEBIT
            // 
            this.LBL_DEBIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_DEBIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_DEBIT.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DEBIT.ForeColor = System.Drawing.Color.Red;
            this.LBL_DEBIT.Location = new System.Drawing.Point(684, 0);
            this.LBL_DEBIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_DEBIT.Name = "LBL_DEBIT";
            this.LBL_DEBIT.Size = new System.Drawing.Size(203, 46);
            this.LBL_DEBIT.TabIndex = 63;
            this.LBL_DEBIT.Text = "0.00";
            this.LBL_DEBIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(895, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 46);
            this.label4.TabIndex = 62;
            this.label4.Text = "الديون";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(534, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 46);
            this.label1.TabIndex = 64;
            this.label1.Text = "المدفوع";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_RECIVE
            // 
            this.LBL_RECIVE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_RECIVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_RECIVE.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RECIVE.ForeColor = System.Drawing.Color.Red;
            this.LBL_RECIVE.Location = new System.Drawing.Point(338, 0);
            this.LBL_RECIVE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_RECIVE.Name = "LBL_RECIVE";
            this.LBL_RECIVE.Size = new System.Drawing.Size(188, 46);
            this.LBL_RECIVE.TabIndex = 65;
            this.LBL_RECIVE.Text = "0.00";
            this.LBL_RECIVE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(207, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 46);
            this.label3.TabIndex = 66;
            this.label3.Text = "المتبقي";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_REMAIN
            // 
            this.LBL_REMAIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_REMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_REMAIN.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_REMAIN.ForeColor = System.Drawing.Color.Red;
            this.LBL_REMAIN.Location = new System.Drawing.Point(4, 0);
            this.LBL_REMAIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_REMAIN.Name = "LBL_REMAIN";
            this.LBL_REMAIN.Size = new System.Drawing.Size(195, 46);
            this.LBL_REMAIN.TabIndex = 67;
            this.LBL_REMAIN.Text = "0.00";
            this.LBL_REMAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBL_NAME);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 71);
            this.panel1.TabIndex = 5;
            // 
            // LBL_NAME
            // 
            this.LBL_NAME.BackColor = System.Drawing.Color.Chocolate;
            this.LBL_NAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_NAME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_NAME.Font = new System.Drawing.Font("STV", 25F, System.Drawing.FontStyle.Bold);
            this.LBL_NAME.ForeColor = System.Drawing.Color.Snow;
            this.LBL_NAME.Location = new System.Drawing.Point(0, 0);
            this.LBL_NAME.Name = "LBL_NAME";
            this.LBL_NAME.Size = new System.Drawing.Size(989, 71);
            this.LBL_NAME.TabIndex = 0;
            this.LBL_NAME.Text = "ألاسم";
            this.LBL_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gET_PERSON_BORROW_DETAILSTableAdapter
            // 
            this.gET_PERSON_BORROW_DETAILSTableAdapter.ClearBeforeFill = true;
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
          
            
            this.tableAdapterManager.T_USERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FRM_R_PERSON_BORROW_DETAILS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "FRM_R_PERSON_BORROW_DETAILS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الديون";
            this.Load += new System.EventHandler(this.FRM_R_PERSON_BORROW_DETAILS_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_PERSON_BORROW_DETAILSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource gET_PERSON_BORROW_DETAILSBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_PERSON_BORROW_DETAILSTableAdapter gET_PERSON_BORROW_DETAILSTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_DEBIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_RECIVE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_REMAIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCCOUNTFULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDBOXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bILLDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMODEBITIQDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOCREDITIQDataGridViewTextBoxColumn;
    }
}