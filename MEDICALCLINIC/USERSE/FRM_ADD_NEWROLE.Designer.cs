
namespace MEDICALCLINIC.USERSE
{
    partial class FRM_ADD_NEWROLE
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.v_GET_FORMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_GET_GROUP_ROLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_GET_GROUP_ROLETableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_GROUP_ROLETableAdapter();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_addper = new System.Windows.Forms.Button();
            this.BTN_UPDATEPER = new System.Windows.Forms.Button();
            this.gET_H_PERMSSION_FROM_BYIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_H_PERMSSION_FROM_BYIDTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_H_PERMSSION_FROM_BYIDTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.v_GET_FORMSTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_FORMSTableAdapter();
            this.gET_permession_formBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gET_permession_formTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.GET_permession_formTableAdapter();
            this.btn_selectAll = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GET_FORMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GET_GROUP_ROLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_H_PERMSSION_FROM_BYIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_permession_formBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            nameLabel.Location = new System.Drawing.Point(735, 56);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(101, 18);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "تعديل مجموعة";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label1.Location = new System.Drawing.Point(735, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 18);
            label1.TabIndex = 5;
            label1.Text = "مجموعة جديدة";
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
            // v_GET_FORMSBindingSource
            // 
            this.v_GET_FORMSBindingSource.DataMember = "V_GET_FORMS";
            this.v_GET_FORMSBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // v_GET_GROUP_ROLEBindingSource
            // 
            this.v_GET_GROUP_ROLEBindingSource.DataMember = "V_GET_GROUP_ROLE";
            this.v_GET_GROUP_ROLEBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // v_GET_GROUP_ROLETableAdapter
            // 
            this.v_GET_GROUP_ROLETableAdapter.ClearBeforeFill = true;
            // 
            // nameComboBox
            // 
            this.nameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameComboBox.DataSource = this.v_GET_GROUP_ROLEBindingSource;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(548, 53);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(181, 26);
            this.nameComboBox.TabIndex = 3;
            this.nameComboBox.ValueMember = "Id";
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(548, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 25);
            this.textBox1.TabIndex = 4;
            // 
            // btn_addper
            // 
            this.btn_addper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addper.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_addper.Location = new System.Drawing.Point(470, 15);
            this.btn_addper.Name = "btn_addper";
            this.btn_addper.Size = new System.Drawing.Size(75, 26);
            this.btn_addper.TabIndex = 6;
            this.btn_addper.Text = "أضافة";
            this.btn_addper.UseVisualStyleBackColor = true;
            this.btn_addper.Click += new System.EventHandler(this.btn_addper_Click);
            // 
            // BTN_UPDATEPER
            // 
            this.BTN_UPDATEPER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_UPDATEPER.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_UPDATEPER.Location = new System.Drawing.Point(470, 53);
            this.BTN_UPDATEPER.Name = "BTN_UPDATEPER";
            this.BTN_UPDATEPER.Size = new System.Drawing.Size(75, 26);
            this.BTN_UPDATEPER.TabIndex = 7;
            this.BTN_UPDATEPER.Text = "تحديث";
            this.BTN_UPDATEPER.UseVisualStyleBackColor = true;
            this.BTN_UPDATEPER.Click += new System.EventHandler(this.BTN_UPDATEPER_Click);
            // 
            // gET_H_PERMSSION_FROM_BYIDBindingSource
            // 
            this.gET_H_PERMSSION_FROM_BYIDBindingSource.DataMember = "GET_H_PERMSSION_FROM_BYID";
            this.gET_H_PERMSSION_FROM_BYIDBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // gET_H_PERMSSION_FROM_BYIDTableAdapter
            // 
            this.gET_H_PERMSSION_FROM_BYIDTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(464, 469);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // v_GET_FORMSTableAdapter
            // 
            this.v_GET_FORMSTableAdapter.ClearBeforeFill = true;
            // 
            // gET_permession_formBindingSource
            // 
            this.gET_permession_formBindingSource.DataMember = "GET_permession_form";
            this.gET_permession_formBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // gET_permession_formTableAdapter
            // 
            this.gET_permession_formTableAdapter.ClearBeforeFill = true;
            // 
            // btn_selectAll
            // 
            this.btn_selectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_selectAll.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_selectAll.Location = new System.Drawing.Point(470, 85);
            this.btn_selectAll.Name = "btn_selectAll";
            this.btn_selectAll.Size = new System.Drawing.Size(259, 26);
            this.btn_selectAll.TabIndex = 10;
            this.btn_selectAll.Text = "تحديد الكل";
            this.btn_selectAll.UseVisualStyleBackColor = true;
            this.btn_selectAll.Click += new System.EventHandler(this.btn_selectAll_Click);
            // 
            // FRM_ADD_NEWROLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 469);
            this.Controls.Add(this.btn_selectAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_UPDATEPER);
            this.Controls.Add(this.btn_addper);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameComboBox);
            this.Name = "FRM_ADD_NEWROLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ألصلاحيات";
            this.Load += new System.EventHandler(this.FRM_ADD_NEWROLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GET_FORMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_GET_GROUP_ROLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_H_PERMSSION_FROM_BYIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gET_permession_formBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource v_GET_GROUP_ROLEBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_GROUP_ROLETableAdapter v_GET_GROUP_ROLETableAdapter;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_addper;
        private System.Windows.Forms.Button BTN_UPDATEPER;
        private System.Windows.Forms.BindingSource gET_H_PERMSSION_FROM_BYIDBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_H_PERMSSION_FROM_BYIDTableAdapter gET_H_PERMSSION_FROM_BYIDTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource v_GET_FORMSBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_FORMSTableAdapter v_GET_FORMSTableAdapter;
        private System.Windows.Forms.BindingSource gET_permession_formBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.GET_permession_formTableAdapter gET_permession_formTableAdapter;
        private System.Windows.Forms.Button btn_selectAll;
    }
}