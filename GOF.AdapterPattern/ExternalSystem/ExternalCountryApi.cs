using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.AdapterPattern.ExternalSystem
{
	public class ExternalCountryApi
	{
		public ExtCountry GetCountry()
		{
			var country = new ExtCountry("USA", "+1", "1500000");
			return country;
		}
	}
}
