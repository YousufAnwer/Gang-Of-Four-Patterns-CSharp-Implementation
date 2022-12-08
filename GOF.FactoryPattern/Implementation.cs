using System;
using System.Reflection;

namespace GOF.FactoryPattern
{

	#region Device
	public interface IDevice
	{
		public string Name { get; set; }
		public string Model { get; set; }
		public string Price { get; set; }
		public void GetDetails();

	}
	public class Mobile : IDevice
	{
		public string Name { get; set; } = "IPhone";
		public string Model { get; set; } = "X";
		public string Price { get; set; }

		public void GetDetails()
		{
			Console.WriteLine("Name: {0}, Model: {1}, Price: {2}", Name, Model, Price);
		}
	}
	public class Laptop : IDevice
	{
		public string Name { get; set; } = "MacbookPro";
		public string Model { get; set; } = "MacbPro-X";
		public string Price { get; set; }

		public void GetDetails()
		{
			Console.WriteLine("Name: {0}, Model: {1}, Price: {2}", Name, Model, Price);
		}
	}

	/// <summary>
	/// Implement null OPbject Patters
	/// </summary>
	public class NullDevice : IDevice
	{
		private static NullDevice _instance;
		private NullDevice()
		{ }

		public static NullDevice Instance
		{
			get
			{
				if (_instance == null)
				{
					return new NullDevice();
				}
				else
				{
					return _instance;
				}

			}
		}
		public string Name { get; set; } = "No Device Found";
		public string Model { get; set; } = "";
		public string Price { get; set; } = "0$";

		public void GetDetails()
		{

		}
	}
	#endregion


	#region DeviceFactory
	public interface IDeviceFactory
	{
		IDevice CreateDevice(DeviceName deviceName);
	}
	public class DeviceFactory : IDeviceFactory
	{

		public IDevice CreateDevice(DeviceName deviceName)
		{
			IDevice device = NullDevice.Instance;
			if (deviceName == DeviceName.Laptop)
			{
				device = new Laptop();
			}
			else if (deviceName == DeviceName.Mobile)
			{
				device = new Mobile();
			}
			return device;
		}
	}
	#endregion


	#region Cables
	public interface ICable
	{
		public string Name { get; set; }
		public string Price { get; set; }
		public string Details { get; set; }
		public void GetDetails();

	}
	public class HDMI : ICable
	{
		public string Name { get; set; } = "HDMI";
		public string Price { get; set; } = "3$";
		public string Details { get; set; } = "HDMI (High definition Media Interface) is a type of computer cable used to transmit high definition video and audio signals.";
		public void GetDetails()
		{
			Console.WriteLine("Name: {0}, Price: {1},\nDetails: {2}", Name, Price, Details);
		}
	}
	public class PS2 : ICable
	{
		public string Name { get; set; } = "PS/2";
		public string Price { get; set; } = "2$";
		public string Details { get; set; } = "The PS/2 cable is a standard cable to connect the mouse and keyboard to the computer system";
		public void GetDetails()
		{
			Console.WriteLine("Name: {0}, Price: {1},\nDetails: {2}", Name, Price, Details);
		}
	}
	public class USB : ICable
	{
		public string Name { get; set; } = "USB";
		public string Price { get; set; } = "4$";
		public string Details { get; set; } = "The USB (Universal Serial Bus) cable is a standard cable used to connect universal devices or personal computers";
		public void GetDetails()
		{
			Console.WriteLine("Name: {0}, Price: {1},\nDetails: {2}", Name, Price, Details);
		}
	}
	/// <summary>
	/// Implement null OPbject Patters
	/// </summary>
	public class NullCable : ICable
	{
		private static NullCable _instanse;

		public static NullCable Instance
		{
			get
			{
				if (_instanse == null)
				{
					return new NullCable();
				}
				else
				{
					return _instanse;
				}

			}
		}

		public string Name { get; set; } = "No Cable Found";
		public string Price { get; set; } = "0$";
		public string Details { get; set; } = "";
		public void GetDetails()
		{
			Console.WriteLine("Name: {0}, Price: {1}, Details: {2}", Name, Price, Details);
		}
	}


	#endregion

	#region CableFactory

	public interface ICableFactory
	{
		ICable CreateCable(CableName cableName);
	}
	public class CableFactory : ICableFactory
	{
		public ICable CreateCable(CableName cableName)
		{
			ICable cable = NullCable.Instance;
			if (cableName == CableName.HDMI)
			{
				cable = new HDMI();
			}
			else if (cableName == CableName.PS2)
			{
				cable = new PS2();
			}
			else if (cableName == CableName.USB)
			{
				cable = new USB();
			}
			return cable;
		}
	}

	#endregion

	#region Enums
	public enum DeviceName
	{
		Mobile = 1,
		Laptop = 2
	}
	public enum CableName
	{
		USB = 1,
		PS2 = 2,
		HDMI = 3,
	}

	#endregion
}
