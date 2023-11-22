﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEDICALCLINIC.PRINT.EXPENSES
{
    public partial class FRM_SHOW_RPT_ALL_EXPENSES : Form
    {
        int IDDRP; DateTime FDATEP; DateTime EDATEP; int FLAGEEP;
        public FRM_SHOW_RPT_ALL_EXPENSES(int IDDR, DateTime FDATE, DateTime EDATE, int FLAGEE)
        {
            InitializeComponent();
            IDDRP = IDDR; FDATEP = FDATE; EDATEP = EDATE; FLAGEEP = FLAGEE;
        }

        

        private void FRM_SHOW_RPT_ALL_EXPENSES_Load(object sender, EventArgs e)
        {

            this.gET_ALL_EXPENSESTableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_ALL_EXPENSES, new System.Nullable<int>(((int)(System.Convert.ChangeType(IDDRP, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(FDATEP, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(EDATEP, typeof(System.DateTime))))),  new System.Nullable<int>(((int)(System.Convert.ChangeType(FLAGEEP, typeof(int))))));
            this.gET_RPT_IMAGEETableAdapter.Fill(this.mEDICAL_CLINIC_DBDataSet.GET_RPT_IMAGEE, new System.Nullable<int>(((int)(System.Convert.ChangeType(7, typeof(int))))));

            DataTable dt = this.mEDICAL_CLINIC_DBDataSet.GET_ALL_EXPENSES;
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
