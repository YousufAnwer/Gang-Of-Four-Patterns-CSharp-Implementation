using System;
using System.Collections.Generic;

namespace GOF.BuilderPattern
{

	public class PersonalCopmuter
	{

		public List<string> Configuration { get; set; }
		public string PcType { get; set; }
		public PersonalCopmuter(string pcType)
		{
			Configuration = new List<string>();
			PcType = pcType;
		}
		public void SetConfig(string config)
		{
			Configuration.Add(config);
		}

		public void ShowConfig()
		{
			Console.WriteLine("PC Type: " + PcType);
			foreach (var item in Configuration)
			{
				Console.WriteLine(item);
			}
		}
	}
	//public abstract class PCBuilder
	//{
	//	public PersonalCopmuter PC { get; set; }
	//	public PCBuilder(string pcType)
	//	{
	//		PC = new PersonalCopmuter(pcType);
	//	}

	//	public abstract void InstallProcessor();
	//	public abstract void InstallRAM();
	//	public abstract void InstallROM();
	//	public abstract void InstallGraphicCard();
	//	public abstract void InstallWindows();
	//	public abstract void ShowConfig();


	//}
	public interface IPCBuilder
	{
		public PersonalCopmuter PC { get; set; }
		public abstract void InstallProcessor();
		public abstract void InstallRAM();
		public abstract void InstallROM();
		public abstract void InstallGraphicCard();
		public abstract void InstallWindows();
		public abstract void ShowConfig();
	}
	public class GamingPCBuilder : IPCBuilder
	{
		public PersonalCopmuter PC { get; set; }
		public GamingPCBuilder()
		{
			PC = new PersonalCopmuter("Gaming PC");
		}
		public void InstallGraphicCard()
		{
			PC.SetConfig("Graphic Card: RTX-4090");
		}

		public void InstallProcessor()
		{
			PC.SetConfig("Processor: Ninth-generation 8-core Intel Core i9");
		}

		public void InstallRAM()
		{
			PC.SetConfig("RAM: 32GB");
		}

		public void InstallROM()
		{
			PC.SetConfig("ROM: 2TB SSD");
		}

		public void InstallWindows()
		{
			PC.SetConfig("Windows: 10.1");
		}
		public void ShowConfig()
		{
			PC.ShowConfig();
		}
	}
	public class NormalPCBuilder : IPCBuilder
	{
		public PersonalCopmuter PC { get; set; }
		public NormalPCBuilder()
		{
			PC = new PersonalCopmuter("Normal PC");
		}

		public void InstallGraphicCard()
		{
			PC.SetConfig("Graphic Card: N/A");
		}

		public void InstallProcessor()
		{
			PC.SetConfig("Processor: Third-generation 2-core Intel Core i3");
		}

		public void InstallRAM()
		{
			PC.SetConfig("RAM: 8GB");
		}

		public void InstallROM()
		{
			PC.SetConfig("ROM: 64GB HDD");
		}

		public void InstallWindows()
		{
			PC.SetConfig("Windows: 7");
		}
		public void ShowConfig()
		{
			PC.ShowConfig();
		}
	}
	public class PCFactory
	{
		public IPCBuilder _builder { get; set; }
		public void construct(IPCBuilder builder)
		{
			_builder = builder;
			_builder.InstallProcessor();
			_builder.InstallROM();
			_builder.InstallRAM();
			_builder.InstallGraphicCard();
			_builder.InstallWindows();
			_builder.ShowConfig();

		}
	}



}
