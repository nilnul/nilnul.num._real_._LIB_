using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.co.be_
{
	public class Powable
		: num.real.co.BeA
	{
		

		public override bool be( R d, R r)
		{
			return real.be_.Positive.Singleton.be(d);
			//throw new NotImplementedException();
		}

		static public Powable Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Powable>.Instance;
			}
		}



	}
}
