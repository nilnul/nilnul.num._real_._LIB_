using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be_
{

	public class Nonneg4float
		: 
		
		nilnul.num.real.Be4floatI
	{

		static public Nonneg4float Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonneg4float>.Instance;
			}
		}

		public bool be(float obj)
		{
			return obj>=0;
		}
	}
}
