using GOF.AdapterPattern.ExternalSystem;
using GOF.AdapterPattern.OurSystem;

namespace GOF.AdapterPattern.Adapter
{
	public interface ICountryAdapter
	{
		Country GetCountry();
	}
	public class CountryAdapter : ICountryAdapter
	{
		public ExtCountry _externalCountry { get; set; }

		public CountryAdapter(ExtCountry externalCountry)
		{
			_externalCountry = externalCountry;
		}

		public Country GetCountry()
		{
			Country country = new Country(_externalCountry.CountryName + "_" + _externalCountry.CountryCode, long.Parse(_externalCountry.Population));
			return country;
		}
	}
}
