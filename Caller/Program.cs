using GOF.AbstractFactory;
using GOF.AdapterPattern.Adapter;
using GOF.AdapterPattern.ExternalSystem;
using GOF.AdapterPatternSocket.Adapter;
using GOF.AdapterPatternSocket.Charger;
using GOF.AdapterPatternSocket.Devices;
using GOF.AdapterPatternSocket.Sockets;
using GOF.BuilderPattern;
using GOF.FactoryPattern;
using System;

namespace Caller
{
	public class Program
	{
		static void Main(string[] args)
		{
			//TestFactory();
			//TestAbstractfactory();
			//TestAdapterPattern();
			//TestSocketAdapter();
			TestBuilderPattern();	
		}
		private static void TestFactory()
		{
			IDeviceFactory deviceFactory = new DeviceFactory();
			IDevice device = deviceFactory.CreateDevice(DeviceName.Mobile);
			device.Price = "1000$";
			device.GetDetails();


			ICableFactory cableFactory = new CableFactory();
			ICable cable = cableFactory.CreateCable(CableName.PS2);
			cable.GetDetails();
		}
		private static void TestAbstractfactory()
		{
			IMegaFactory megaFactory = new MegaFactory();

			IDeviceFactory deviceFactory = megaFactory.CreateDeviceFactory();
			IDevice device = deviceFactory.CreateDevice(DeviceName.Laptop);
			device.Price = "2000$";
			device.GetDetails();


			ICableFactory cableFactory = megaFactory.CreateCableFactory();
			ICable cable = cableFactory.CreateCable(CableName.USB);
			cable.GetDetails();

		}
		private static void TestAdapterPattern()
		{
			//Calling External Api
			var apiResponse = new ExternalCountryApi().GetCountry();
			ICountryAdapter adapter = new CountryAdapter(apiResponse);
			var country = adapter.GetCountry();
			Console.WriteLine(country.CountryName_Code);
			Console.WriteLine(country.Inhabitance);


		}

		private static void TestSocketAdapter()
		{
			I3PinCharger threePinCharger = new ThreePinCharger();
			//I2PinCharger twoPinCharger = new TwoPinCharger();

			MacBookPro mac = new MacBookPro();
			mac.AttachCharger(threePinCharger);

			IChargingAdapter adapter = new ChargingAdapter();
			var twoPinCharger1 = adapter.Addept(threePinCharger);


			Socket twoPinSocket = new Socket();
			twoPinSocket.PlugInCharger(twoPinCharger1);
		}

		private static void TestBuilderPattern()
		{
			IPCBuilder gamingPCBuilder = new GamingPCBuilder();
			IPCBuilder normalPCBuilder = new NormalPCBuilder();	
			PCFactory pCFactory=new PCFactory();
			pCFactory.construct(gamingPCBuilder);
		}
	}
}
