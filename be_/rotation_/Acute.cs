using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.rotation_
{
	/// <summary>
	/// as rotation, in (-t/4,t/4)
	/// </summary>
	public class Acute : real.BeI
	{
		public bool be(RealI obj)
		{
			return nilnul.num.real.bound_.rotation_.Acute.Create().contains(obj);
			throw new NotImplementedException();
		}
	}
}
