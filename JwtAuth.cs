using DocuSign.eSign.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DocuSign.eSign.Client.Auth.OAuth;

namespace ConsoleApp1
{
    public static class JwtAuth
    {
        public static OAuthToken AuthenticateWithJwt(string api, string clientId, string impersonatedUserId, string authServer, byte[] privateKeyBytes)
        {
            var docuSignClient = new DocuSignClient();
            //var apiType = Enum.Parse<ExamplesApiType>(api);
            var scopes = new List<string>
                {
                    "signature",
                    "impersonation",
                };
            //if (apiType == ExamplesApiType.Rooms)
            //{
            //    scopes.AddRange(new List<string>
            //    {
            //        "dtr.rooms.read",
            //        "dtr.rooms.write",
            //        "dtr.documents.read",
            //        "dtr.documents.write",
            //        "dtr.profile.read",
            //        "dtr.profile.write",
            //        "dtr.company.read",
            //        "dtr.company.write",
            //        "room_forms",
            //    });
            //}

            //if (apiType == ExamplesApiType.Click)
            //{
            //    scopes.AddRange(new List<string>
            //    {
            //        "click.manage",
            //        "click.send",
            //    });
            //}

            //if (apiType == ExamplesApiType.Monitor)
            //{
            //    scopes.AddRange(new List<string>
            //    {
            //        "signature",
            //        "impersonation",
            //    });
            //}

            //if (apiType == ExamplesApiType.Admin)
            //{
            //    scopes.AddRange(new List<string>
            //    {
            //        "user_read",
            //        "user_write",
            //        "account_read",
            //        "organization_read",
            //        "group_read",
            //        "permission_read",
            //        "identity_provider_read",
            //        "domain_read",
            //        "user_data_redact",
            //        "asset_group_account_read",
            //        "asset_group_account_clone_write",
            //        "asset_group_account_clone_read",
            //    });
            //}

            //if (apiType == ExamplesApiType.WebForms)
            //{
            //    scopes.Add("webforms_read");
            //    scopes.Add("webforms_instance_write");
            //    scopes.Add("webforms_instance_read");
            //}

            return docuSignClient.RequestJWTUserToken(
                clientId,
                impersonatedUserId,
                authServer,
                privateKeyBytes,
                1,
                scopes);

        }
    }
}
