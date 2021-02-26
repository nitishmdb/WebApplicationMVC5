using Microsoft.AspNet.Identity;
using System;
using System.Security.Claims;
using System.Security.Principal;

namespace WebApplicationMVC5.Extension
{
    public static class IdentityExtensions
    {
        public static string GetRoleName(this IIdentity identity)
        {
            if (identity == null)
            {
                throw new ArgumentNullException("identity");
            }
            var ci = identity as ClaimsIdentity;
            if (ci != null)
            {
                return ci.FindFirstValue(ClaimTypes.Role);
            }
            return null;
        }
    }
}