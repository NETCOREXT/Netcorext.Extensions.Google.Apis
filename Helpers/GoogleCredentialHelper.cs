using System.Text;
using Google.Apis.Auth.OAuth2;

namespace Netcorext.Extensions.Google.Apis.Helpers;

public static class GoogleCredentialHelper
{
    public static GoogleCredential FromBase64String(string base64)
    {
        var bytes = Convert.FromBase64String(base64);
        var json = Encoding.UTF8.GetString(bytes);
        return GoogleCredential.FromJson(json);
    }
}