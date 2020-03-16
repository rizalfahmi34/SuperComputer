using System;

namespace TheSuperComputer
{
	class Vga
	{
		//brand, graphic clock, memory clock
		private String brand;
		private int graphicsClock;//Mhz
		private int memoryClock;//Mhz

		public Vga(string brand, int graphicsClock, int memoryClock)
		{
			this.brand = brand;
			this.graphicsClock = graphicsClock;
			this.memoryClock = memoryClock;
		}

		public String getBrand()
		{
			return this.brand;
		}

		public int getGraphicsClock()
		{
			return this.graphicsClock;
		}

		public int getMemoryClock()
		{
			return this.memoryClock;
		}

		public override String ToString()
		{
			return $"VGA brand : {this.brand} ; VGA clock graphics : {this.graphicsClock} ; VGA clock memory : {this.memoryClock}";
		}
	}
}