using GOF.AdapterPatternSocket.Charger;
using System;

namespace GOF.AdapterPatternSocket.Devices
{
    public class MacBookPro
    {
        public string Name { get; set; }
        public void AttachCharger(I3PinCharger threePinCharger)
        {
            Console.WriteLine("Charger Connected..");
        }
    }
	public class IPhone
	{
		public string Name { get; set; }
		public void AttachCharger(I2PinCharger twoPinCharger)
		{
			Console.WriteLine("Charger Connected..");
		}
	}
}
