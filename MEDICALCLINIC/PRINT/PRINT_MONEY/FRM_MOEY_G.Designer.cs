namespace MEDICALCLINIC.PRINT.PRINT_MONEY
{
    partial class FRM_MOEY_G
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
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.pGETMONEYAVALPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_MONEY_AVAL_PTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_MONEY_AVAL_PTableAdapter();
            this.P_GET_MONEY_AVAL_PBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETMONEYAVALPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_GET_MONEY_AVAL_PBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.P_GET_MONEY_AVAL_PBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MEDICALCLINIC.PRINT.PRINT_MONEY.RPT_MONEY_F.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(637, 562);
            this.reportViewer1.TabIndex = 0;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pGETMONEYAVALPBindingSource
            // 
            this.pGETMONEYAVALPBindingSource.DataMember = "P_GET_MONEY_AVAL_P";
            this.pGETMONEYAVALPBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_MONEY_AVAL_PTableAdapter
            // 
            this.p_GET_MONEY_AVAL_PTableAdapter.ClearBeforeFill = true;
            // 
            // P_GET_MONEY_AVAL_PBindingSource
            // 
            this.P_GET_MONEY_AVAL_PBindingSource.DataMember = "P_GET_MONEY_AVAL_P";
            this.P_GET_MONEY_AVAL_PBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // FRM_MOEY_G
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 562);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRM_MOEY_G";
            this.Text = "تقرير النقديه ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_MOEY_G_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETMONEYAVALPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_GET_MONEY_AVAL_PBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource P_GET_MONEY_AVAL_PBindingSource;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource pGETMONEYAVALPBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_MONEY_AVAL_PTableAdapter p_GET_MONEY_AVAL_PTableAdapter;
      //  private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_MONEY_AVAL_RTableAdapter p_GET_MONEY_AVAL_RTableAdapter;
    }
}