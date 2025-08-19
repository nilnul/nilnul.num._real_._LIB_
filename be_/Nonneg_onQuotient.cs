using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_
{

	public class Nonneg_onQuotient
		: 
		be_.neg.Anto_onQuotient
		,
		nilnul.num.real.BeI_onQuoient
		,
		BeDblI
	{


		public bool be(double obj)
		{
			return obj >=0;
		}
		static public Nonneg_onQuotient Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonneg_onQuotient>.Instance;
			}
		}
	}
}
