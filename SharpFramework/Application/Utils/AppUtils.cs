using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VK.Application.Builders;
using VK.Framework.Utils;

namespace VK.Application.Utils
{
    public class AppUtils
    {
        private static readonly log4net.ILog Log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static JObject GetResponse(string url)
        {
            Log.Info($"Gets JObject for {url}");
            string response = ApiUtils.PostRequest(url);
            return JObject.Parse(response);
        }
    }
}