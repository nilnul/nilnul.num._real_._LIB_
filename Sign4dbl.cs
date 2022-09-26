using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/// <summary>
	/// if it is <see cref="be_.AboutNil4Dbl"/>, return null.
	/// otherwise return true if it's positive, false if negative.
	/// </summary>
	public class Sign4dbl
		: nilnul.obj.SignI<double>
	{
		public bool? sign(double obj)
		{
			var aboutNil = nilnul.num.real.be_.AboutNil4Dbl.Injected.be(obj);
			if (aboutNil)
			{
				return null;
			}
			return obj > 0;

		}


		static public Sign4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Sign4dbl>.Instance;
			}
		}

	}
}
