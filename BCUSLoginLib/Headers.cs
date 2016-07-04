using System;
namespace BCUSLoginLib
{
	public class Headers 
	{

		public string Guid { get; set; }

		public string Bcus_user_agent { get; set; }

		public string Accept { get; set; }

		public string Content_type { get; set; }
	
		public string Device_hash { get; set; }

		public Headers()
		{
			Guid = "123456789";
			Bcus_user_agent = "iphone/android";
			Accept = "application/json";
			Content_type = "application/x-www-form-urlencoded";
			Device_hash = "e195cd483e887c81f282319dd4d40b8ff929631a";
		}
	}
}

