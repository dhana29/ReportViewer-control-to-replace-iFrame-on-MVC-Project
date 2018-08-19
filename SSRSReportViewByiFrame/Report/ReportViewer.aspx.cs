using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;

namespace SSRSReportViewByiFrame.Report
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string reportFolder = "reportFolder";

                    ReportingServiceViewModel model = new ReportingServiceViewModel();
                    List<ReportParameter> paramCollection = new List<ReportParameter>();

                    rvSiteMapping.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
                    rvSiteMapping.ServerReport.ReportServerUrl = new Uri(System.Configuration.ConfigurationManager.AppSettings["ReportServerUrl"].ToUpper()); // Add the Reporting Server URL  
                    rvSiteMapping.ServerReport.ReportPath = String.Format("{0}{1}", reportFolder, Request["ReportName"].ToString());
                    rvSiteMapping.ServerReport.ReportServerCredentials = model.ServerCredentials;
                    rvSiteMapping.ServerReport.SetParameters(paramCollection.ToArray());
                    rvSiteMapping.ShowParameterPrompts = false;
                    rvSiteMapping.SizeToReportContent = true;
                    rvSiteMapping.ShowPrintButton = false;
                    rvSiteMapping.ShowDocumentMapButton = true;
                    rvSiteMapping.Width = Unit.Percentage(100);
                    rvSiteMapping.Height = Unit.Percentage(100);
                    rvSiteMapping.ShowBackButton = false;
                    rvSiteMapping.ServerReport.Refresh();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}