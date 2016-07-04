using System;
using System.Collections.Generic;
namespace BCUSLoginLib
{
	public class Parameters
	{
		Dictionary<int, string> paramMap = new Dictionary<int, string>();

		public enum Param
		{
			userID,
			password,
			version,
			osVersion,
			appVersion
		}

		public enum Platform
		{
			iphone,
			android
		}

		public void setParam(Param param, string value)
		{
			paramMap.Add((int)param, value);
		}

		public void setPlatform(Platform platform)
		{
			paramMap.Add(((int)Param.appVersion) + 1, platform.ToString());
		}

		public bool getURLParamString(Param param, out string result)
		{
			result = null;

			string value;

			bool status = paramMap.TryGetValue((int)param, out value);

			if (status)
			{
				result = param.ToString() + "=" + value;
			}

			return status;
		}
		public bool getURLPlatformString(out string result)
		{
			result = null;
			string value;
			bool status = paramMap.TryGetValue((int)Param.appVersion + 1, out value);

			if (status)
			{
				result = "platform" + "=" + value;
			}
			return status;
		}

	}
}

