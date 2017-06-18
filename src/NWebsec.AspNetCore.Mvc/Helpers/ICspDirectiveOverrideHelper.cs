// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.Annotations;
using NWebsec.Core.Common.HttpHeaders.Configuration;
using NWebsec.AspNetCore.Mvc.Helpers.CspOverride;

namespace NWebsec.AspNetCore.Mvc.Helpers
{
    public interface ICspDirectiveOverrideHelper
    {
        [NotNull]
        ICspDirectiveConfiguration GetOverridenCspDirectiveConfig([NotNull]CspDirectiveOverride directiveOverride, [CanBeNull]ICspDirectiveConfiguration directiveConfig);

        [NotNull]
        ICspSandboxDirectiveConfiguration GetOverridenCspSandboxConfig([NotNull]CspSandboxOverride directiveOverride, [CanBeNull]ICspSandboxDirectiveConfiguration directiveConfig);

        [NotNull]
        ICspPluginTypesDirectiveConfiguration GetOverridenCspPluginTypesConfig([NotNull]CspPluginTypesOverride directiveOverride, [CanBeNull]ICspPluginTypesDirectiveConfiguration directiveConfig);

        [NotNull]
        ICspMixedContentDirectiveConfiguration GetOverridenCspMixedContentConfig([NotNull]CspMixedContentOverride config, [CanBeNull]ICspMixedContentDirectiveConfiguration directiveToOverride);
    }
}