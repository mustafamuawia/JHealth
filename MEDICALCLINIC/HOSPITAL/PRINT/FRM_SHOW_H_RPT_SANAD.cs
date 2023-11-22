using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.HOSPITAL.PRINT
{
    public partial class FRM_SHOW_H_RPT_SANAD : MEDICALCLINIC.HOSPITAL.BaseHospital
    {
        int drid,fid;
        DateTime fdatey, edatey;
        public FRM_SHOW_H_RPT_SANAD(int drcodr,DateTime fdate,DateTime edate,int idf)
        {
            InitializeComponent();
            drid = drcodr;
            fid = idf;
            fdatey = fdate;
            edatey = edate;
        }
        public FRM_SHOW_H_RPT_SANAD()
        {
            InitializeComponent();
            
        }

        private void FRM_SHOW_H_RPT_SANAD_Load(object sender, EventArgs e)
        {
            this.gET_H_OPEARTION_REPORTTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_H_OPEARTION_REPORT, new System.Nullable<int>(((int)(System.Convert.ChangeType(drid, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(fdatey, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(edatey, typeof(System.DateTime))))), "", new System.Nullable<int>(((int)(System.Convert.ChangeType(fid, typeof(int))))));
            this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(1, typeof(int))))));

            DataTable dt = this.mEDICAL_CLINIC_DBDataSet.GET_H_OPEARTION_REPORT;
            DataTable dt1 = this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE;
            reportViewer1.Visible = true;
            //reportViewer1.LocalReport.ReportPath = "MEDICALCLINIC.HOSPITAL.PRINT.Report_op.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt1));
            this.reportViewer1.RefreshReport();
        }

       
      
    }
}
