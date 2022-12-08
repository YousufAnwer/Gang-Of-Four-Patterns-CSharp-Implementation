using GOF.AbstractFactory;
using GOF.FactoryPattern;
using GOF.second;
using System;

namespace Caller
{
	public class Program
	{
		static void Main(string[] args)
		{
			//TestFactory();
			//TestAbstractfactory();

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
	}
}
