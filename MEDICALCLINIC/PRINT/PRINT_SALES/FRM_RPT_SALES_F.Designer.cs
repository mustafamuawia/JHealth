﻿namespace MEDICALCLINIC.PRINT.PRINT_SALES
{
    partial class FRM_RPT_SALES_F
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
            this.P_GET_SALES_PRT_PBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mEDICAL_CLINIC_DBDataSet = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pGETSALESPRTPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_GET_SALES_PRT_PTableAdapter = new MEDICALCLINIC.MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_SALES_PRT_PTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.P_GET_SALES_PRT_PBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETSALESPRTPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // P_GET_SALES_PRT_PBindingSource
            // 
            this.P_GET_SALES_PRT_PBindingSource.DataMember = "P_GET_SALES_PRT_P";
            this.P_GET_SALES_PRT_PBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
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
            reportDataSource1.Value = this.P_GET_SALES_PRT_PBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MEDICALCLINIC.PRINT.PRINT_SALES.RPT_SALES_F.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(675, 374);
            this.reportViewer1.TabIndex = 0;
            // 
            // pGETSALESPRTPBindingSource
            // 
            this.pGETSALESPRTPBindingSource.DataMember = "P_GET_SALES_PRT_P";
            this.pGETSALESPRTPBindingSource.DataSource = this.mEDICAL_CLINIC_DBDataSet;
            // 
            // p_GET_SALES_PRT_PTableAdapter
            // 
            this.p_GET_SALES_PRT_PTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_RPT_SALES_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 374);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRM_RPT_SALES_F";
            this.Text = "المبيعات عامة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_RPT_SALES_F_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.P_GET_SALES_PRT_PBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAL_CLINIC_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGETSALESPRTPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource P_GET_SALES_PRT_PBindingSource;
        private MEDICAL_CLINIC_DBDataSet mEDICAL_CLINIC_DBDataSet;
        private System.Windows.Forms.BindingSource pGETSALESPRTPBindingSource;
        private MEDICAL_CLINIC_DBDataSetTableAdapters.P_GET_SALES_PRT_PTableAdapter p_GET_SALES_PRT_PTableAdapter;
    }
}