namespace MEDICALCLINIC.PRINT.PRINT_SALES
{
    partial class FRM_DOCTOR_SEAL
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.P_GET_SALES_BY_DOCTOR_PBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pGETSALESBYDOCTORPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_SALES_BY_DOCTOR_PTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_SALES_BY_DOCTOR_PTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.P_GET_SALES_BY_DOCTOR_PBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETSALESBYDOCTORPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // P_GET_SALES_BY_DOCTOR_PBindingSource
            // 
            this.P_GET_SALES_BY_DOCTOR_PBindingSource.DataMember = "P_GET_SALES_BY_DOCTOR_P";
            this.P_GET_SALES_BY_DOCTOR_PBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.P_GET_SALES_BY_DOCTOR_PBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.P_GET_SALES_BY_DOCTOR_PBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MEDICALCLINIC.PRINT.PRINT_SALES.RPT_SEALS_DOCT_F.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(522, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // pGETSALESBYDOCTORPBindingSource
            // 
            this.pGETSALESBYDOCTORPBindingSource.DataMember = "P_GET_SALES_BY_DOCTOR_P";
            this.pGETSALESBYDOCTORPBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_SALES_BY_DOCTOR_PTableAdapter
            // 
            this.p_GET_SALES_BY_DOCTOR_PTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_DOCTOR_SEAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRM_DOCTOR_SEAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مبيعات حسب الدكتور";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_DOCTOR_SEAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P_GET_SALES_BY_DOCTOR_PBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETSALESBYDOCTORPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource P_GET_SALES_BY_DOCTOR_PBindingSource;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource pGETSALESBYDOCTORPBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_SALES_BY_DOCTOR_PTableAdapter p_GET_SALES_BY_DOCTOR_PTableAdapter;
    }
}