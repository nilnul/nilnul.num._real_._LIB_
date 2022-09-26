using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_
{

	public class Nonneg
		: 
		be_.neg.Anto
		,
		nilnul.num.real.BeI
		,
		BeDblI
	{

		static public Nonneg Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonneg>.Instance;
			}
		}

		public bool be(double obj)
		{
			return obj >=0;
			throw new NotImplementedException();
		}
	}
}
