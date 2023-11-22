namespace MEDICALCLINIC.REPORT
{
    partial class FRM_PROFIT
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_PROFIT));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.E_DATE = new System.Windows.Forms.DateTimePicker();
            this.F_DATE = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vGETAITEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.v_A_DOCTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_MONEY_BY_TOWDATE_AVAL_PBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_BOX_ALLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.p_BOX_ALLTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter();
            this.tableAdapterManager = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager();
            this.p_GET_BOOKING_BY_DOC_RPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_BOOKING_BY_DOC_RPTTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DOC_RPTTableAdapter();
            this.p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter();
            this.v_A_DOCTORTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter();
            this.v_GET_A_ITEMTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_A_ITEMTableAdapter();
            this.p_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_MONEY_BY_ONEDATE_AVAL_PTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_MONEY_BY_ONEDATE_AVAL_PTableAdapter();
            this.p_GET_MONEY_BY_TOWDATE_AVAL_PTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_MONEY_BY_TOWDATE_AVAL_PTableAdapter();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGETAITEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_MONEY_BY_TOWDATE_AVAL_PBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOX_ALLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DOC_RPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(118, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 18);
            label2.TabIndex = 57;
            label2.Text = "من تأريخ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label3.Location = new System.Drawing.Point(117, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 18);
            label3.TabIndex = 57;
            label3.Text = "الى تأريخ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.Color.Yellow;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 145);
            this.button4.TabIndex = 61;
            this.button4.Text = "خروج";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.E_DATE);
            this.groupBox6.Controls.Add(this.F_DATE);
            this.groupBox6.Controls.Add(label3);
            this.groupBox6.Controls.Add(label2);
            this.groupBox6.Font = new System.Drawing.Font("STV", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox6.Location = new System.Drawing.Point(132, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox6.Size = new System.Drawing.Size(189, 145);
            this.groupBox6.TabIndex = 60;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "حسب تأريخ محدد";
            // 
            // E_DATE
            // 
            this.E_DATE.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.E_DATE.Location = new System.Drawing.Point(16, 100);
            this.E_DATE.Name = "E_DATE";
            this.E_DATE.Size = new System.Drawing.Size(156, 33);
            this.E_DATE.TabIndex = 60;
            // 
            // F_DATE
            // 
            this.F_DATE.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.F_DATE.Location = new System.Drawing.Point(17, 44);
            this.F_DATE.Name = "F_DATE";
            this.F_DATE.Size = new System.Drawing.Size(156, 33);
            this.F_DATE.TabIndex = 60;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Font = new System.Drawing.Font("STV", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(327, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(384, 145);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "حسب اسم المادة";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("STV", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1.Location = new System.Drawing.Point(260, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 26);
            this.checkBox1.TabIndex = 64;
            this.checkBox1.Text = "كل المواد";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vGETAITEMBindingSource;
            this.comboBox1.DisplayMember = "ITEM_MAME";
            this.comboBox1.Font = new System.Drawing.Font("STV", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 26);
            this.comboBox1.TabIndex = 63;
            this.comboBox1.ValueMember = "BARCODE";
            // 
            // vGETAITEMBindingSource
            // 
            this.vGETAITEMBindingSource.DataMember = "V_GET_A_ITEM";
            this.vGETAITEMBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Yellow;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(6, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 114);
            this.button5.TabIndex = 62;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("STV", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(6, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 53);
            this.button1.TabIndex = 59;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // v_A_DOCTORBindingSource
            // 
            this.v_A_DOCTORBindingSource.DataMember = "V_A_DOCTOR";
            this.v_A_DOCTORBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_MONEY_BY_TOWDATE_AVAL_PBindingSource
            // 
            this.p_GET_MONEY_BY_TOWDATE_AVAL_PBindingSource.DataMember = "P_GET_MONEY_BY_TOWDATE_AVAL_P";
            this.p_GET_MONEY_BY_TOWDATE_AVAL_PBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_BOX_ALLBindingSource
            // 
            this.p_BOX_ALLBindingSource.DataMember = "P_BOX_ALL";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // p_GET_BOOKING_BY_DOC_RPTBindingSource
            // 
            this.p_GET_BOOKING_BY_DOC_RPTBindingSource.DataMember = "P_GET_BOOKING_BY_DOC_RPT";
            this.p_GET_BOOKING_BY_DOC_RPTBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_BOOKING_BY_DOC_RPTTableAdapter
            // 
            this.p_GET_BOOKING_BY_DOC_RPTTableAdapter.ClearBeforeFill = true;
            // 
            // p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource
            // 
            this.p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource.DataMember = "P_GET_BOOKING_BY_DOC_TOW_D_RPT";
            this.p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter
            // 
            this.p_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter.ClearBeforeFill = true;
            // 
            // v_A_DOCTORTableAdapter
            // 
            this.v_A_DOCTORTableAdapter.ClearBeforeFill = true;
            // 
            // v_GET_A_ITEMTableAdapter
            // 
            this.v_GET_A_ITEMTableAdapter.ClearBeforeFill = true;
            // 
            // p_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource
            // 
            this.p_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource.DataMember = "P_GET_MONEY_BY_ONEDATE_AVAL_P";
            this.p_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_MONEY_BY_ONEDATE_AVAL_PTableAdapter
            // 
            this.p_GET_MONEY_BY_ONEDATE_AVAL_PTableAdapter.ClearBeforeFill = true;
            // 
            // p_GET_MONEY_BY_TOWDATE_AVAL_PTableAdapter
            // 
            this.p_GET_MONEY_BY_TOWDATE_AVAL_PTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_PROFIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(720, 175);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FRM_PROFIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير الارباح";
            this.Load += new System.EventHandler(this.FRM_SEARCH_SANAD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vGETAITEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_A_DOCTORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_MONEY_BY_TOWDATE_AVAL_PBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_BOX_ALLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DOC_RPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource p_BOX_ALLBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_BOX_ALLTableAdapter p_BOX_ALLTableAdapter;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker E_DATE;
        private System.Windows.Forms.DateTimePicker F_DATE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource p_GET_BOOKING_BY_DOC_RPTBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DOC_RPTTableAdapter p_GET_BOOKING_BY_DOC_RPTTableAdapter;
        private System.Windows.Forms.BindingSource p_GET_BOOKING_BY_DOC_TOW_D_RPTBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter p_GET_BOOKING_BY_DOC_TOW_D_RPTTableAdapter;
        private System.Windows.Forms.BindingSource v_A_DOCTORBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_A_DOCTORTableAdapter v_A_DOCTORTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource vGETAITEMBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.V_GET_A_ITEMTableAdapter v_GET_A_ITEMTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.BindingSource p_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_MONEY_BY_ONEDATE_AVAL_PTableAdapter p_GET_MONEY_BY_ONEDATE_AVAL_PTableAdapter;
        private System.Windows.Forms.BindingSource p_GET_MONEY_BY_TOWDATE_AVAL_PBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_MONEY_BY_TOWDATE_AVAL_PTableAdapter p_GET_MONEY_BY_TOWDATE_AVAL_PTableAdapter;
    }
}