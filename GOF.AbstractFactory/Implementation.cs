using GOF.FactoryPattern;
using System;

namespace GOF.AbstractFactory
{

	public interface IMegaFactory
	{
		IDeviceFactory CreateDeviceFactory();
		ICableFactory CreateCableFactory();
	}
	public class MegaFactory : IMegaFactory
	{
		public ICableFactory CreateCableFactory()
		{
			return new CableFactory();
		}

		public IDeviceFactory CreateDeviceFactory()
		{
			return new DeviceFactory();
		}
	}
}
