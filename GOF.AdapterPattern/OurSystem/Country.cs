using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.AdapterPattern.OurSystem
{
	public class Country
	{
		public string CountryName_Code { get; set; }
		public long Inhabitance { get; set; }

		public Country(string countryName_code, long inhabitance)
		{
			CountryName_Code = countryName_code;
			Inhabitance = inhabitance;
		}

		

	}
}
