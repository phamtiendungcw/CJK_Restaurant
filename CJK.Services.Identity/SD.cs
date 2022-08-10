using Duende.IdentityServer.Models;
using System.Collections.Generic;

namespace CJK.Services.Identity
{
    public static class SD
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("CJK", "CJK Server"),
                new ApiScope("read","Read your data"),
                new ApiScope("write","Write your data"),
                new ApiScope("delete","Delete your data")
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client()
                {
                    ClientId = "client",
                    ClientSecrets = {new Secret("secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = {"read","write","profile"}
                },
            };
    }
}
