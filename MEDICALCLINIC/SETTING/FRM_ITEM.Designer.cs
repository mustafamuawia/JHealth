namespace MEDICALCLINIC.SETTING
{
    partial class FRM_ITEM
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
            System.Windows.Forms.Label CLIENT_PHONE1Label;
            System.Windows.Forms.Label CLIENT_NAME_ENLabel;
            System.Windows.Forms.Label CLIENT_NAME_ARLabel;
            System.Windows.Forms.Label CLIENT_CODELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ITEM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.GROUPComboBox = new System.Windows.Forms.ComboBox();
            this.t_CATEGORIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.BARCODETextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ITEM_NAME_ARTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ITEM_CODETextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.t_CATEGORIESTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.T_CATEGORIESTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            CLIENT_PHONE1Label = new System.Windows.Forms.Label();
            CLIENT_NAME_ENLabel = new System.Windows.Forms.Label();
            CLIENT_NAME_ARLabel = new System.Windows.Forms.Label();
            CLIENT_CODELabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_CATEGORIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CLIENT_PHONE1Label
            // 
            CLIENT_PHONE1Label.AutoSize = true;
            CLIENT_PHONE1Label.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_PHONE1Label.Location = new System.Drawing.Point(577, 162);
            CLIENT_PHONE1Label.Name = "CLIENT_PHONE1Label";
            CLIENT_PHONE1Label.Size = new System.Drawing.Size(95, 22);
            CLIENT_PHONE1Label.TabIndex = 60;
            CLIENT_PHONE1Label.Text = ":المجموعة";
            // 
            // CLIENT_NAME_ENLabel
            // 
            CLIENT_NAME_ENLabel.AutoSize = true;
            CLIENT_NAME_ENLabel.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_NAME_ENLabel.Location = new System.Drawing.Point(577, 120);
            CLIENT_NAME_ENLabel.Name = "CLIENT_NAME_ENLabel";
            CLIENT_NAME_ENLabel.Size = new System.Drawing.Size(119, 22);
            CLIENT_NAME_ENLabel.TabIndex = 59;
            CLIENT_NAME_ENLabel.Text = ":باركود المادة";
            // 
            // CLIENT_NAME_ARLabel
            // 
            CLIENT_NAME_ARLabel.AutoSize = true;
            CLIENT_NAME_ARLabel.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_NAME_ARLabel.Location = new System.Drawing.Point(577, 69);
            CLIENT_NAME_ARLabel.Name = "CLIENT_NAME_ARLabel";
            CLIENT_NAME_ARLabel.Size = new System.Drawing.Size(103, 22);
            CLIENT_NAME_ARLabel.TabIndex = 58;
            CLIENT_NAME_ARLabel.Text = ":اسم المادة";
            // 
            // CLIENT_CODELabel
            // 
            CLIENT_CODELabel.AutoSize = true;
            CLIENT_CODELabel.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            CLIENT_CODELabel.Location = new System.Drawing.Point(577, 23);
            CLIENT_CODELabel.Name = "CLIENT_CODELabel";
            CLIENT_CODELabel.Size = new System.Drawing.Size(101, 22);
            CLIENT_CODELabel.TabIndex = 57;
            CLIENT_CODELabel.Text = ":كود المادة";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 20);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Controls.Add(this.GROUPComboBox);
            this.groupBox2.Controls.Add(CLIENT_PHONE1Label);
            this.groupBox2.Controls.Add(CLIENT_NAME_ENLabel);
            this.groupBox2.Controls.Add(CLIENT_NAME_ARLabel);
            this.groupBox2.Controls.Add(CLIENT_CODELabel);
            this.groupBox2.Controls.Add(this.BARCODETextBoxX);
            this.groupBox2.Controls.Add(this.ITEM_NAME_ARTextBoxX);
            this.groupBox2.Controls.Add(this.ITEM_CODETextBoxX);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 254);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Controls.Add(this.BTN_SEARCH);
            this.flowLayoutPanel1.Controls.Add(this.BTN_NEW);
            this.flowLayoutPanel1.Controls.Add(this.BTN_SAVE);
            this.flowLayoutPanel1.Controls.Add(this.BTN_EDIT);
            this.flowLayoutPanel1.Controls.Add(this.BTN_DELETE);
            this.flowLayoutPanel1.Controls.Add(this.BTN_EXIT);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 196);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(720, 55);
            this.flowLayoutPanel1.TabIndex = 103;
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.Color.Black;
            this.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH.Image = ((System.Drawing.Image)(resources.GetObject("BTN_SEARCH.Image")));
            this.BTN_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SEARCH.Location = new System.Drawing.Point(603, 3);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(114, 49);
            this.BTN_SEARCH.TabIndex = 98;
            this.BTN_SEARCH.Text = "بحث";
            this.BTN_SEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_NEW.ForeColor = System.Drawing.Color.White;
            this.BTN_NEW.Image = ((System.Drawing.Image)(resources.GetObject("BTN_NEW.Image")));
            this.BTN_NEW.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_NEW.Location = new System.Drawing.Point(483, 3);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(114, 49);
            this.BTN_NEW.TabIndex = 99;
            this.BTN_NEW.Text = "جديد";
            this.BTN_NEW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_NEW.UseVisualStyleBackColor = false;
            this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_SAVE.ForeColor = System.Drawing.Color.White;
            this.BTN_SAVE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_SAVE.Image")));
            this.BTN_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_SAVE.Location = new System.Drawing.Point(363, 3);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(114, 49);
            this.BTN_SAVE.TabIndex = 100;
            this.BTN_SAVE.Text = "حفظ";
            this.BTN_SAVE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SAVE.UseVisualStyleBackColor = false;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EDIT.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EDIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EDIT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_EDIT.Image")));
            this.BTN_EDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EDIT.Location = new System.Drawing.Point(243, 3);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(114, 49);
            this.BTN_EDIT.TabIndex = 101;
            this.BTN_EDIT.Text = "تعديل";
            this.BTN_EDIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EDIT.UseVisualStyleBackColor = false;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTN_EDIT_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_DELETE.ForeColor = System.Drawing.Color.White;
            this.BTN_DELETE.Image = ((System.Drawing.Image)(resources.GetObject("BTN_DELETE.Image")));
            this.BTN_DELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_DELETE.Location = new System.Drawing.Point(123, 3);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(114, 49);
            this.BTN_DELETE.TabIndex = 102;
            this.BTN_DELETE.Text = "حذف";
            this.BTN_DELETE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DELETE.UseVisualStyleBackColor = false;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.BackColor = System.Drawing.Color.Red;
            this.BTN_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXIT.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EXIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EXIT.Image = ((System.Drawing.Image)(resources.GetObject("BTN_EXIT.Image")));
            this.BTN_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_EXIT.Location = new System.Drawing.Point(3, 3);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(114, 49);
            this.BTN_EXIT.TabIndex = 103;
            this.BTN_EXIT.Text = "خروج";
            this.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // GROUPComboBox
            // 
            this.GROUPComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GROUPComboBox.DataSource = this.t_CATEGORIESBindingSource;
            this.GROUPComboBox.DisplayMember = "CATEGORIS_NAME";
            this.GROUPComboBox.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold);
            this.GROUPComboBox.FormattingEnabled = true;
            this.GROUPComboBox.Location = new System.Drawing.Point(203, 157);
            this.GROUPComboBox.Name = "GROUPComboBox";
            this.GROUPComboBox.Size = new System.Drawing.Size(364, 30);
            this.GROUPComboBox.TabIndex = 2;
            this.GROUPComboBox.ValueMember = "CATEGORIS_CODE";
            // 
            // t_CATEGORIESBindingSource
            // 
            this.t_CATEGORIESBindingSource.DataMember = "T_CATEGORIES";
            this.t_CATEGORIESBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BARCODETextBoxX
            // 
            this.BARCODETextBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BARCODETextBoxX.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.BARCODETextBoxX.Border.Class = "TextBoxBorder";
            this.BARCODETextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.BARCODETextBoxX.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BARCODETextBoxX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BARCODETextBoxX.Location = new System.Drawing.Point(203, 112);
            this.BARCODETextBoxX.Name = "BARCODETextBoxX";
            this.BARCODETextBoxX.Size = new System.Drawing.Size(364, 39);
            this.BARCODETextBoxX.TabIndex = 1;
            this.BARCODETextBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BARCODETextBoxX.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.BARCODETextBoxX.WatermarkColor = System.Drawing.Color.DimGray;
            this.BARCODETextBoxX.WatermarkText = "باركود المادة";
            this.BARCODETextBoxX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CLIENT_NAME_ENTextBoxX_KeyDown);
            // 
            // ITEM_NAME_ARTextBoxX
            // 
            this.ITEM_NAME_ARTextBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ITEM_NAME_ARTextBoxX.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.ITEM_NAME_ARTextBoxX.Border.Class = "TextBoxBorder";
            this.ITEM_NAME_ARTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ITEM_NAME_ARTextBoxX.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ITEM_NAME_ARTextBoxX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ITEM_NAME_ARTextBoxX.Location = new System.Drawing.Point(203, 64);
            this.ITEM_NAME_ARTextBoxX.Name = "ITEM_NAME_ARTextBoxX";
            this.ITEM_NAME_ARTextBoxX.Size = new System.Drawing.Size(364, 39);
            this.ITEM_NAME_ARTextBoxX.TabIndex = 0;
            this.ITEM_NAME_ARTextBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ITEM_NAME_ARTextBoxX.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.ITEM_NAME_ARTextBoxX.WatermarkColor = System.Drawing.Color.DimGray;
            this.ITEM_NAME_ARTextBoxX.WatermarkText = "اسم المادة";
            this.ITEM_NAME_ARTextBoxX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CLIENT_NAME_ARTextBoxX_KeyDown);
            // 
            // ITEM_CODETextBoxX
            // 
            this.ITEM_CODETextBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ITEM_CODETextBoxX.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.ITEM_CODETextBoxX.Border.Class = "TextBoxBorder";
            this.ITEM_CODETextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ITEM_CODETextBoxX.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ITEM_CODETextBoxX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ITEM_CODETextBoxX.Location = new System.Drawing.Point(348, 16);
            this.ITEM_CODETextBoxX.Name = "ITEM_CODETextBoxX";
            this.ITEM_CODETextBoxX.ReadOnly = true;
            this.ITEM_CODETextBoxX.Size = new System.Drawing.Size(219, 39);
            this.ITEM_CODETextBoxX.TabIndex = 53;
            this.ITEM_CODETextBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ITEM_CODETextBoxX.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.ITEM_CODETextBoxX.WatermarkColor = System.Drawing.Color.DimGray;
            this.ITEM_CODETextBoxX.WatermarkText = "كود المادة";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // t_CATEGORIESTableAdapter
            // 
            this.t_CATEGORIESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FormsNamesTableAdapter = null;
            this.tableAdapterManager.GroupRolsTableAdapter = null;
            this.tableAdapterManager.MessageTableAdapter = null;
            this.tableAdapterManager.PermessionsTableAdapter = null;
            this.tableAdapterManager.PersonTableAdapter = null;
            this.tableAdapterManager.T_ACCOUNT_TYPETableAdapter = null;
            this.tableAdapterManager.T_ACCOUNTSTableAdapter = null;
            this.tableAdapterManager.T_BILL_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOK_TYPETableAdapter = null;
            this.tableAdapterManager.T_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_BOX_DETAILS_TTableAdapter = null;
            this.tableAdapterManager.T_BOX_HISTORYTableAdapter = null;
            this.tableAdapterManager.T_BOX_TTableAdapter = null;
            this.tableAdapterManager.T_BOXTableAdapter = null;
            this.tableAdapterManager.T_CASH_DEBTTableAdapter = null;
            this.tableAdapterManager.T_CATEGORIESTableAdapter = this.t_CATEGORIESTableAdapter;
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
           // 
            this.tableAdapterManager.T_SEX_STATETableAdapter = null;
            this.tableAdapterManager.T_STATETableAdapter = null;
           //
            this.tableAdapterManager.T_TOOTH_BOOKINGTableAdapter = null;
            this.tableAdapterManager.T_TRATMENT_TOOTHTableAdapter = null;
            this.tableAdapterManager.T_TYPE_MOVETableAdapter = null;
            this.tableAdapterManager.T_TYPE_PAYTableAdapter = null;
           // this.tableAdapterManager.T_USER_AUTH_SCTableAdapter = null;
            this.tableAdapterManager.T_USERSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FRM_ITEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 274);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FRM_ITEM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة ادخال المواد";
            this.Load += new System.EventHandler(this.FRM_ITEM_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t_CATEGORIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal DevComponents.DotNetBar.Controls.TextBoxX ITEM_NAME_ARTextBoxX;
        internal DevComponents.DotNetBar.Controls.TextBoxX ITEM_CODETextBoxX;
        internal DevComponents.DotNetBar.Controls.TextBoxX BARCODETextBoxX;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource t_CATEGORIESBindingSource;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.T_CATEGORIESTableAdapter t_CATEGORIESTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.ComboBox GROUPComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.Button BTN_NEW;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_EXIT;
    }
}