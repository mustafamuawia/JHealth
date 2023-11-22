namespace MEDICALCLINIC.OPERATION_PP
{
    partial class FRM_PAY_OPERTION_PRICE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PAY_OPERTION_PRICE));
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_PRICE_TOT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.LBL_NAME = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.p_GET_PRICE_OPERTION_BY_GRIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_PRICE_OPERTION_BY_GRIDTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_PRICE_OPERTION_BY_GRIDTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_PAID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.TXT_REMAIN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_CASH = new System.Windows.Forms.Button();
            this.BTN_NO_CASH = new System.Windows.Forms.Button();
            this.BTN_PARTIAL_CASH = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_PRICE_OPERTION_BY_GRIDBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("STV", 18.5F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "أسم المريض";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PRICE_TOT
            // 
            this.TXT_PRICE_TOT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXT_PRICE_TOT.Border.Class = "TextBoxBorder";
            this.TXT_PRICE_TOT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_PRICE_TOT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_PRICE_TOT.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold);
            this.TXT_PRICE_TOT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TXT_PRICE_TOT.Location = new System.Drawing.Point(4, 4);
            this.TXT_PRICE_TOT.Name = "TXT_PRICE_TOT";
            this.TXT_PRICE_TOT.Size = new System.Drawing.Size(221, 39);
            this.TXT_PRICE_TOT.TabIndex = 0;
            this.TXT_PRICE_TOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PRICE_TOT.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_PRICE_TOT.WatermarkColor = System.Drawing.Color.DimGray;
            this.TXT_PRICE_TOT.WatermarkText = "المبلغ الكلي";
            // 
            // LBL_NAME
            // 
            this.LBL_NAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.LBL_NAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_NAME.Font = new System.Drawing.Font("STV", 18.5F, System.Drawing.FontStyle.Bold);
            this.LBL_NAME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LBL_NAME.Location = new System.Drawing.Point(4, 54);
            this.LBL_NAME.Name = "LBL_NAME";
            this.LBL_NAME.Size = new System.Drawing.Size(368, 52);
            this.LBL_NAME.TabIndex = 2;
            this.LBL_NAME.Text = "----------";
            this.LBL_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(126, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 44);
            this.button3.TabIndex = 104;
            this.button3.Text = "أستلام الملبغ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.Location = new System.Drawing.Point(4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 44);
            this.button8.TabIndex = 105;
            this.button8.Text = "خروج";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.Locale = new System.Globalization.CultureInfo("ar-IQ");
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_GET_PRICE_OPERTION_BY_GRIDBindingSource
            // 
            this.p_GET_PRICE_OPERTION_BY_GRIDBindingSource.DataMember = "P_GET_PRICE_OPERTION_BY_GRID";
            this.p_GET_PRICE_OPERTION_BY_GRIDBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_PRICE_OPERTION_BY_GRIDTableAdapter
            // 
            this.p_GET_PRICE_OPERTION_BY_GRIDTableAdapter.ClearBeforeFill = true;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.02235F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.97765F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 392);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 148);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.42105F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 186);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.TXT_PRICE_TOT, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.TXT_PAID, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.TXT_REMAIN, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 60);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.50505F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.49495F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(372, 124);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(232, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "البـــاقي";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(232, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "الواصـــل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(232, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "المجموع";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PAID
            // 
            this.TXT_PAID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXT_PAID.Border.Class = "TextBoxBorder";
            this.TXT_PAID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_PAID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_PAID.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold);
            this.TXT_PAID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TXT_PAID.Location = new System.Drawing.Point(4, 45);
            this.TXT_PAID.Name = "TXT_PAID";
            this.TXT_PAID.Size = new System.Drawing.Size(221, 39);
            this.TXT_PAID.TabIndex = 1;
            this.TXT_PAID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PAID.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_PAID.WatermarkColor = System.Drawing.Color.DimGray;
            this.TXT_PAID.WatermarkText = "الواصل";
            this.TXT_PAID.TextChanged += new System.EventHandler(this.TXT_PAID_TextChanged);
            this.TXT_PAID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PAID_KeyPress);
            // 
            // TXT_REMAIN
            // 
            this.TXT_REMAIN.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXT_REMAIN.Border.Class = "TextBoxBorder";
            this.TXT_REMAIN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.TXT_REMAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_REMAIN.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold);
            this.TXT_REMAIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TXT_REMAIN.Location = new System.Drawing.Point(4, 86);
            this.TXT_REMAIN.Name = "TXT_REMAIN";
            this.TXT_REMAIN.Size = new System.Drawing.Size(221, 39);
            this.TXT_REMAIN.TabIndex = 2;
            this.TXT_REMAIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_REMAIN.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.TXT_REMAIN.WatermarkColor = System.Drawing.Color.DimGray;
            this.TXT_REMAIN.WatermarkText = "المتبقي";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 54);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.77301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.22699F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel3.Controls.Add(this.BTN_CASH, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN_NO_CASH, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BTN_PARTIAL_CASH, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(372, 54);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // BTN_CASH
            // 
            this.BTN_CASH.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_CASH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_CASH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CASH.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold);
            this.BTN_CASH.ForeColor = System.Drawing.Color.Yellow;
            this.BTN_CASH.Image = ((System.Drawing.Image)(resources.GetObject("BTN_CASH.Image")));
            this.BTN_CASH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_CASH.Location = new System.Drawing.Point(217, 4);
            this.BTN_CASH.Name = "BTN_CASH";
            this.BTN_CASH.Size = new System.Drawing.Size(151, 46);
            this.BTN_CASH.TabIndex = 107;
            this.BTN_CASH.Text = "نقد";
            this.BTN_CASH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CASH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_CASH.UseVisualStyleBackColor = false;
            this.BTN_CASH.Click += new System.EventHandler(this.BTN_CASH_Click);
            // 
            // BTN_NO_CASH
            // 
            this.BTN_NO_CASH.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_NO_CASH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_NO_CASH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NO_CASH.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold);
            this.BTN_NO_CASH.ForeColor = System.Drawing.Color.Yellow;
            this.BTN_NO_CASH.Image = ((System.Drawing.Image)(resources.GetObject("BTN_NO_CASH.Image")));
            this.BTN_NO_CASH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_NO_CASH.Location = new System.Drawing.Point(108, 4);
            this.BTN_NO_CASH.Name = "BTN_NO_CASH";
            this.BTN_NO_CASH.Size = new System.Drawing.Size(102, 46);
            this.BTN_NO_CASH.TabIndex = 106;
            this.BTN_NO_CASH.Text = "أجل";
            this.BTN_NO_CASH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_NO_CASH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_NO_CASH.UseVisualStyleBackColor = false;
            this.BTN_NO_CASH.Click += new System.EventHandler(this.BTN_CASH_Click);
            // 
            // BTN_PARTIAL_CASH
            // 
            this.BTN_PARTIAL_CASH.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_PARTIAL_CASH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_PARTIAL_CASH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PARTIAL_CASH.Font = new System.Drawing.Font("STV", 16F, System.Drawing.FontStyle.Bold);
            this.BTN_PARTIAL_CASH.ForeColor = System.Drawing.Color.Yellow;
            this.BTN_PARTIAL_CASH.Image = ((System.Drawing.Image)(resources.GetObject("BTN_PARTIAL_CASH.Image")));
            this.BTN_PARTIAL_CASH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_PARTIAL_CASH.Location = new System.Drawing.Point(4, 4);
            this.BTN_PARTIAL_CASH.Name = "BTN_PARTIAL_CASH";
            this.BTN_PARTIAL_CASH.Size = new System.Drawing.Size(97, 46);
            this.BTN_PARTIAL_CASH.TabIndex = 105;
            this.BTN_PARTIAL_CASH.Text = "جزئي";
            this.BTN_PARTIAL_CASH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_PARTIAL_CASH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_PARTIAL_CASH.UseVisualStyleBackColor = false;
            this.BTN_PARTIAL_CASH.Click += new System.EventHandler(this.BTN_CASH_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.LBL_NAME, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 37);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(376, 107);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 31);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 31);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(347, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Money ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel6.Controls.Add(this.button8, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 338);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(376, 52);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // FRM_PAY_OPERTION_PRICE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 392);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FRM_PAY_OPERTION_PRICE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفع مبلغ العملية";
            this.Load += new System.EventHandler(this.FRM_PAY_OPERTION_PRICE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_PRICE_OPERTION_BY_GRIDBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource p_GET_PRICE_OPERTION_BY_GRIDBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_PRICE_OPERTION_BY_GRIDTableAdapter p_GET_PRICE_OPERTION_BY_GRIDTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        public DevComponents.DotNetBar.Controls.TextBoxX TXT_PRICE_TOT;
        public System.Windows.Forms.Label LBL_NAME;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public DevComponents.DotNetBar.Controls.TextBoxX TXT_PAID;
        public DevComponents.DotNetBar.Controls.TextBoxX TXT_REMAIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button BTN_CASH;
        private System.Windows.Forms.Button BTN_NO_CASH;
        private System.Windows.Forms.Button BTN_PARTIAL_CASH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}