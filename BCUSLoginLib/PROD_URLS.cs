using System;
namespace BCUSLoginLib
{
	public class PROD_URLS
	{
		private String authenticate;
		public PROD_URLS()
		{
			Authenticate = "https://prod-m.barclaycardus.com/mobileservice/authentiate/v3";
		}

		public string Authenticate
		{
			get
			{
				return authenticate;
			}

			set
			{
				authenticate = value;
			}
		}
	}
}

