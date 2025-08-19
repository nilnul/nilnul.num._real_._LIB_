using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R1 = nilnul.num.RealI;

namespace nilnul.num.real.be_
{

	/// <summary>
	/// current bound is singleton
	/// </summary>
	public class Quotient
		: nilnul.num.real.BeI
		,
		num.real.BeI_onQuoient
	{


		public bool be(R1 obj)
		{
			return obj is nilnul.num.real_.Quotient ||
				nilnul.num.quotient.bound_.closed.be_.Single.Singleton.be(obj.current)

				;
			//throw new NotImplementedException();
		}

		public bool be(in RealI_onQuotient val)
		{
			return val is nilnul.num.real_.Quotient ||
				(val.current.end == val.current.begin);

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