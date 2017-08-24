﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdkTests
{
    class TestConfig
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string IntegratorKey { get; set; }
        public string Host { get; set; }
        public DocuSign.eSign.Client.ApiClient ApiCLient { get; set; }
        public DocuSign.eSign.Client.Configuration Configuration { get; set; }
        public string AccountId { get; set; }
        public string RecipientEmail { get; set; }
        public string RecipientName { get; set; }
        public string TemplateRoleName { get; set; }
        public string TemplateId { get; set; }
        public string EnvelopeId { get; set; }
        public string ReturnUrl { get; set; }

        public TestConfig(string username = null, string password = null, string integratorKey = null, string host = null, string recipientEmail = null, string recipientName = null, string templateRoleName = null, string templateId = null, string returnUrl = null)
        {
            this.Host = (host != null) ? host : "https://demo.docusign.net/restapi";
            this.Username = (username != null) ? username : "node_sdk@mailinator.com";
            this.Password = (password != null) ? password : "***REMOVED***";
            this.IntegratorKey = (integratorKey != null) ? integratorKey : "***REMOVED***";

            this.RecipientEmail = (recipientEmail != null) ? recipientEmail : "node_sdk@mailinator.com";
            this.RecipientName = (recipientName != null) ? recipientName : "Pat Developer";

            this.TemplateRoleName = (templateRoleName != null) ? templateRoleName : "bob";
            this.TemplateId = (templateId != null) ? templateId : "***REMOVED***";

            this.ReturnUrl = (returnUrl != null) ? returnUrl : "https://www.docusign.com/devcenter";
        }
    }
}