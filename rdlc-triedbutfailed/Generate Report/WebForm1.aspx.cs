using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Reporting.WebForms;

namespace Generate_Report
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            FinalTechnicalTestDataSet m = new FinalTechnicalTestDataSet();
            string cs = @"data source =.; initial catalog=FinalTechnicalTest; Trusted_Connection=False; Connection Timeout=60;";
            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("select * from stock", cn);
            da.Fill(m, m.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("stock", m.Tables[0]);
            this.ReportViewer1.LocalReport.DataSources.Clear();
            this.ReportViewer1.LocalReport.DataSources.Add(rds);
            this.ReportViewer1.LocalReport.Refresh();
            */
           
        }
    }
}