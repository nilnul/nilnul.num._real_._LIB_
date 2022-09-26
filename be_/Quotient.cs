using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.be_
{

	/// <summary>
	/// current bound is singleton
	/// </summary>
	public class Quotient
		: nilnul.num.real.BeI
	{


		public bool be(R obj)
		{
			return obj is nilnul.num.real_.Quotient ||
				nilnul.num.quotient.bound_.closed.be_.Single.Singleton.be(obj.current)

				;
			//throw new NotImplementedException();
		}

		static public Quotient Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Quotient>.Instance;
			}
		}
	}
}