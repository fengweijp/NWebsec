// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.Mvc.HttpHeaders.Csp.Internals;

namespace NWebsec.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the block-all-mixed-content directive for the CSP header (CSP 3.0). 
    /// </summary>
    public class CspBlockAllMixedContentReportOnlyAttribute : CspBlockAllMixedContentAttributeBase
    {
        protected override bool ReportOnly
        {
            get { return true; }
        }
    }
}