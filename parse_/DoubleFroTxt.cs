using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.parse_
{
	public class Double
	{

		static public double Eval(string txt) {
			var t = txt.Trim();
			if (string.IsNullOrWhiteSpace(t))
			{
				return 0;
			}
			if (t==".")
			{
				return 0;
			}
			if (t.StartsWith("."))
			{
				t = "0" + t;

			}

			return double.Parse(t);
		}
	}
}
