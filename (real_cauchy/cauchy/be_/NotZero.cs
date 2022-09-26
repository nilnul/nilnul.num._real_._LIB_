using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = nilnul.num._real.CauchyI2;

namespace nilnul.num._real.cauchy.be_
{
	/// <summary>
	/// 
	/// </summary>
	public class Nonnil:nilnul.num._real.cauchy.BeI
	{

		public bool be(C obj)
		{
			return _real._cauchy.approach.be_.limit_.Nonnil.Singleton.be(obj.approach);

			//throw new NotImplementedException();
		}

		static public Nonnil Singleton
		{
			get
			{
				return nilnul.Singleton1<Nonnil>.Instance;
			}
		}

	}

}
