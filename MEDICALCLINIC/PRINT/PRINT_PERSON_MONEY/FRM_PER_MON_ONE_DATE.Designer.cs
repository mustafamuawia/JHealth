namespace MEDICALCLINIC.PRINT.PRINT_PERSON_MONEY
{
    partial class FRM_PER_MON_ONE_DATE
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.P_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_PERSON_MONEY_BY_ONEDATE_AVAL_PTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_PERSON_MONEY_BY_ONEDATE_AVAL_PTableAdapter();
            this.pGETPERSONMONEYBYONEDATEAVALPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.pGETPERSONMONEYBYONEDATEAVALPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.P_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETPERSONMONEYBYONEDATEAVALPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETPERSONMONEYBYONEDATEAVALPBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pGETPERSONMONEYBYONEDATEAVALPBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MEDICALCLINIC.PRINT.PRINT_PERSON_MONEY.RPT_PER_MON_ONE_DATE_F.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(948, 550);
            this.reportViewer1.TabIndex = 0;
            // 
            // P_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource
            // 
            this.P_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource.DataMember = "P_GET_MONEY_BY_ONEDATE_AVAL_P";
            this.P_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_PERSON_MONEY_BY_ONEDATE_AVAL_PTableAdapter
            // 
            this.p_GET_PERSON_MONEY_BY_ONEDATE_AVAL_PTableAdapter.ClearBeforeFill = true;
            // 
            // pGETPERSONMONEYBYONEDATEAVALPBindingSource
            // 
            this.pGETPERSONMONEYBYONEDATEAVALPBindingSource.DataMember = "P_GET_PERSON_MONEY_BY_ONEDATE_AVAL_P";
            this.pGETPERSONMONEYBYONEDATEAVALPBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pGETPERSONMONEYBYONEDATEAVALPBindingSource1
            // 
            this.pGETPERSONMONEYBYONEDATEAVALPBindingSource1.DataMember = "P_GET_PERSON_MONEY_BY_ONEDATE_AVAL_P";
            this.pGETPERSONMONEYBYONEDATEAVALPBindingSource1.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // FRM_PER_MON_ONE_DATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 550);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRM_PER_MON_ONE_DATE";
            this.Text = "تقرير ديون الزبون حسب تاريخ محدد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_PER_MON_ONE_DATE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETPERSONMONEYBYONEDATEAVALPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETPERSONMONEYBYONEDATEAVALPBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pGETPERSONMONEYBYONEDATEAVALPBindingSource1;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource P_GET_MONEY_BY_ONEDATE_AVAL_PBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_PERSON_MONEY_BY_ONEDATE_AVAL_PTableAdapter p_GET_PERSON_MONEY_BY_ONEDATE_AVAL_PTableAdapter;
        private System.Windows.Forms.BindingSource pGETPERSONMONEYBYONEDATEAVALPBindingSource;
      ///  private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_PERSON_MONEY_BY_ONEDATE_AVAL_RTableAdapter p_GET_PERSON_MONEY_BY_ONEDATE_AVAL_RTableAdapter;
    }
}