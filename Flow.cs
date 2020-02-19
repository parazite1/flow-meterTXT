using System;
using System.Collections.Generic;
using System.Text;

namespace flow_meterTXT {
	class Flow {
		double factor;

		public Flow() {
			this.factor = 100; // расход на 100 КМ
		}

		public double getpowresvr(double voltank, double fuelconsavg) {

			return voltank / fuelconsavg * this.factor;
		}

		
	}
}
