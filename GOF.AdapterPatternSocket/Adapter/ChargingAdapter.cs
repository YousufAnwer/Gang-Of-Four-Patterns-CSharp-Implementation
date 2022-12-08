using GOF.AdapterPatternSocket.Charger;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.AdapterPatternSocket.Adapter
{
	public interface IChargingAdapter
	{
		I2PinCharger Addept(I3PinCharger threePinCharger);
	}
	public class ChargingAdapter : IChargingAdapter
	{
		public I2PinCharger Addept(I3PinCharger threePinCharger)
		{

			var twoPinCharger = new TwoPinCharger();
			twoPinCharger.Neutral = threePinCharger.Neutral;
			twoPinCharger.Phase = threePinCharger.Phase;
			return twoPinCharger;

		}
	}
}
