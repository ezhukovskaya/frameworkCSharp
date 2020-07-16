using VK.Application.Constants.Paths;
using VK.Framework.Utils;

namespace VK.Application.Builders
{
    public static class RequestBuilder
    {
        private static readonly string ApiVersion =
            XMLUtils.GetNodeValue("apiVersion", FilePathConstants.AppConfigurationPath);

        private static string CreateRequest(string apiMethodName, string apiMethod, string parameters)
        {
            ParamsBuilder paramsBuilder = new ParamsBuilder();
            paramsBuilder.AddParams(UrlConstants.ApiUrl + apiMethodName + apiMethod, parameters);
            return paramsBuilder.ToString();
        }
    }
}