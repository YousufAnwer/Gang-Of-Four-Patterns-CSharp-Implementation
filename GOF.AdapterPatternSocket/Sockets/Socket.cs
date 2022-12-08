using GOF.AdapterPatternSocket.Charger;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.AdapterPatternSocket.Sockets
{
	public class Socket
	{
		public int Volts { get; set; } = 200;
		public void PlugInCharger(I2PinCharger twoPinCharger)
		{
			Console.WriteLine("Plug Connected to socket...");
		}
	}
}
