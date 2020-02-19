using System;
using System.Collections.Generic;
using System.Text;

namespace flow_meterTXT {
	class datacontrol {
		public static double inputnumdata() {
			Double number;
			string strdata;
			bool notcorrect = false;
			do {
				strdata = Console.ReadLine();
				if (Double.TryParse(strdata, out number)) {
					number = Double.Parse(strdata);
					notcorrect = false;
				} else {
					notcorrect = true;
					Console.WriteLine("Повторите ввод");
					Console.WriteLine("введены не корректные данные");
				}
			} while (notcorrect);
			return number;
		}
		public static bool inputYesNO() {
			bool resume = true;
			bool correct;
			string usersinput;
			Console.WriteLine("Хотите продолжить? Y / N ");
			do {
				usersinput = Console.ReadLine();
				usersinput = usersinput.ToLower();
				correct = true;
				switch (usersinput) {
				case "y":
					resume = true;
					break;
				case "n":
					resume = false;
					break;
				default:
					correct = false;
					Console.WriteLine("Нужно на клавиатуре нажать клавишу Y или N");
					break;
				}
			} while (!correct);
			return resume;
		}

	}
}
