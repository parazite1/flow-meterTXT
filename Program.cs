using System;

namespace flow_meterTXT {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("---Расчет запаса хода---");
			double voltank;
			double fuelconsv;

			do {
				Console.WriteLine("введите объем бака  в литрах");
				voltank = datacontrol.inputnumdata();
				Console.WriteLine("введите средний расход топлива в литрах");
				fuelconsv = datacontrol.inputnumdata();
				Flow flow = new Flow();
				Console.WriteLine("результат = "+flow.getpowresvr(voltank, fuelconsv)+" KM ");

			} while (datacontrol.inputYesNO());

		}
	}
}
