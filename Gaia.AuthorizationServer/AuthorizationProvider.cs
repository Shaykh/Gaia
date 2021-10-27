using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Gaia.AuthorizationServer
{
    public class AuthorizationProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            if (context.UserName == "admin" && context.Password == "admin")
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
                identity.AddClaim(new Claim("username", "admin"));
                identity.AddClaim(new Claim(ClaimTypes.Name, "Shaykh Alamin"));
                context.Validated(identity);
            }
            else if (context.UserName == "maho" && context.Password == "maho")
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                identity.AddClaim(new Claim("username", "maho"));
                identity.AddClaim(new Claim(ClaimTypes.Name, "Magic Yannick"));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "Le nom d'utilisateur et le mot de passe fournis sont incorrects");
                return;
            }
        }
    }
}