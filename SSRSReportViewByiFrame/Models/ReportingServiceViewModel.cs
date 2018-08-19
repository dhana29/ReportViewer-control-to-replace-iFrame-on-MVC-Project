using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Reporting.Common;
using Microsoft.Reporting.WebForms;

namespace SSRSReportViewByiFrame.Report
{
    public class ReportingServiceViewModel
    {
        #region Public Properties

        public ReportServerCredentials ServerCredentials { get { return new ReportServerCredentials(); } }
        public String ReportPath { get; set; }
        public String ReportPathURL { get; set; }
        public ReportParameter[] parameters { get; set; }
        public Uri ReportServerURL { get { return new Uri(System.Configuration.ConfigurationManager.AppSettings["ReportServerUrl"].ToUpper()); } }

        #endregion Public Properties

        #region Constructor

        public ReportingServiceViewModel()
        {
        }
        #endregion Constructor
    }
}

