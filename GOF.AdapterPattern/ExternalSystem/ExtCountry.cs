using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.AdapterPattern.ExternalSystem
{
	public class ExtCountry
	{
		public string CountryName { get; set; }
		public string CountryCode { get; set; }
		public string Population { get; set; }
		public ExtCountry(string countryName, string countryCode, string population)
		{
			CountryName = countryName;
			CountryCode = countryCode;
			Population = population;
		}
	}
}
