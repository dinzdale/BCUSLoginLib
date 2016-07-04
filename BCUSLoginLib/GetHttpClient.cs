
using System.Net.Http;
using System.Net.Http.Headers;

using ModernHttpClient;


namespace BCUSLoginLib
{
	public class GetHttpClient
	{
		HttpClient httpClient = new HttpClient(new NativeMessageHandler());
		public GetHttpClient(Headers headers)
		{
			//Guid = "123456789";
			//Bcus_user_agent = "iphone/android";
			//Accept = "application/json";
			//Content_type = "application/x-www-form-urlencoded";
			//Device_hash = "e195cd483e887c81f282319dd4d40b8ff929631a";
			httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(headers.Accept));
			httpClient.DefaultRequestHeaders.Add("bcus_user_agent", headers.Bcus_user_agent);
			httpClient.DefaultRequestHeaders.Add("guid", headers.Guid);
			httpClient.DefaultRequestHeaders.Add("content_type", headers.Content_type);
			httpClient.DefaultRequestHeaders.Add("device_hash", headers.Device_hash);
		}
		public GetHttpClient(Parameters parameters)
		{
			
		}
	}
}

