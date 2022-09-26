using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_.bound_
{
	/// <summary>
	/// </summary>
	public class Nil : nilnul.num.real.BeI
	{
		public bool be(RealI obj)
		{
			return nilnul.num.quotient.bound_.closed.be_.Nil.Singleton.be(obj.current);
		}

		static public Nil Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nil>.Instance;
			}
		}

	}
}
