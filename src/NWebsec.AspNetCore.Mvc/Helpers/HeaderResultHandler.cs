﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using NWebsec.Core.Common.HttpHeaders;

namespace NWebsec.AspNetCore.Mvc.Helpers
{
    public class HeaderResultHandler : IHeaderResultHandler
    {
        public void HandleHeaderResult(HttpResponse response, HeaderResult result)
        {
            if (result == null)
            {
                return;
            }

            switch (result.Action)
            {
                case HeaderResult.ResponseAction.Set:
                    response.Headers[result.Name] = result.Value;
                    return;
                case HeaderResult.ResponseAction.Remove:
                    response.Headers.Remove(result.Name);
                    return;

            }
        }  
    }
}