using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Reporting.WebForms;
using System.Net;

namespace SSRSReportViewByiFrame.Report
{
    public sealed class ReportServerCredentials : IReportServerCredentials
    {
        #region Private Properties
        private string _username;
        private string _password;
        private string _domain;
        private string _reportFolder;
        #endregion Private Properties

        #region Public Properties
        public System.Security.Principal.WindowsIdentity ImpersonationUser
        {
            get { return null; }
        }

        public System.Net.ICredentials NetworkCredentials
        {
            get { return new NetworkCredential(_username, _password, _domain); }
        }

        #endregion Public Properties

        #region Constructor
        public ReportServerCredentials(string userName, string password, string domain, string reportFolder)
        {
            _username = userName;
            _password = password;
            _domain = domain;
            _reportFolder = reportFolder;
        }
        public ReportServerCredentials()
        {
            var appSetting = System.Configuration.ConfigurationManager.AppSettings;
            _username = appSetting["ReportServerUser"];
            _password = appSetting["ReportServerPassword"];
            _domain = appSetting["ReportServerDomain"];
            _reportFolder = appSetting["ReportFolder"];
        }
        #endregion Constructor

        public Uri ReportServerUrl { get { return new Uri(System.Configuration.ConfigurationManager.AppSettings["ReportServerUrl"].ToUpper()); } }

        public string ReportFolder { get { return _reportFolder; } }

        public int Timeout { get { return 60000; } }
    }
}



