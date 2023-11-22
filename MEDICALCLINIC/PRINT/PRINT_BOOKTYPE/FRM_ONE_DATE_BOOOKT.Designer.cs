namespace MEDICALCLINIC.PRINT
{
    partial class FRM_ONE_DATE_BOOOKT
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.pGETBOOKTYPEPRTONEDATEPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_BOOK_TYPE_PRT_ONE_DATE_PTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOK_TYPE_PRT_ONE_DATE_PTableAdapter();
            this.P_GET_BOOK_TYPE_PRT_ONE_DATE_PBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETBOOKTYPEPRTONEDATEPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_GET_BOOK_TYPE_PRT_ONE_DATE_PBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.P_GET_BOOK_TYPE_PRT_ONE_DATE_PBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MEDICALCLINIC.PRINT.PRINT_BOOKTYPE.PRT_BOOKING_T_1DATE_F.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(795, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // mEDICAL_CLINIC_DBDataSet
            // 
            this.mEDICAL_CLINIC_DBDataSet.DataSetName = "MEDICAL_CLINIC_DBDataSet";
            this.mEDICAL_CLINIC_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pGETBOOKTYPEPRTONEDATEPBindingSource
            // 
            this.pGETBOOKTYPEPRTONEDATEPBindingSource.DataMember = "P_GET_BOOK_TYPE_PRT_ONE_DATE_P";
            this.pGETBOOKTYPEPRTONEDATEPBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_BOOK_TYPE_PRT_ONE_DATE_PTableAdapter
            // 
            this.p_GET_BOOK_TYPE_PRT_ONE_DATE_PTableAdapter.ClearBeforeFill = true;
            // 
            // P_GET_BOOK_TYPE_PRT_ONE_DATE_PBindingSource
            // 
            this.P_GET_BOOK_TYPE_PRT_ONE_DATE_PBindingSource.DataMember = "P_GET_BOOK_TYPE_PRT_ONE_DATE_P";
            this.P_GET_BOOK_TYPE_PRT_ONE_DATE_PBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // FRM_ONE_DATE_BOOOKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 522);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRM_ONE_DATE_BOOOKT";
            this.Text = "تقرير الحجز حسب تاريخ محدد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_ONE_DATE_BOOOKT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETBOOKTYPEPRTONEDATEPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_GET_BOOK_TYPE_PRT_ONE_DATE_PBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource P_GET_BOOK_TYPE_PRT_ONE_DATE_PBindingSource;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource pGETBOOKTYPEPRTONEDATEPBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOK_TYPE_PRT_ONE_DATE_PTableAdapter p_GET_BOOK_TYPE_PRT_ONE_DATE_PTableAdapter;
        //private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_BOOK_TYPE_ONE_DATE_RTableAdapter p_GET_BOOK_TYPE_ONE_DATE_RTableAdapter;
    }
}