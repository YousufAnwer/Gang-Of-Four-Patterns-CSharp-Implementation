using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.AdapterPatternSocket.Charger
{
	public interface ICharger
	{
		public bool Phase { get; set; }
		public bool Neutral { get; set; }
	}
	public interface IEarthCharger
	{
		public bool Earth { get; set; }
	}
	public interface I2PinCharger: ICharger
	{

	}
	public interface I3PinCharger: ICharger,IEarthCharger
	{

	}
	
	public class ThreePinCharger : I3PinCharger
	{
		public bool Phase { get; set; }
		public bool Neutral { get; set; }
		public bool Earth { get; set; }
	}
	public class TwoPinCharger : I2PinCharger
	{
		public bool Phase { get; set; }
		public bool Neutral { get; set; }
	}
}
