using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real._cauchy.approach.be
{
	public class Vow<TBe> : VowI
		where TBe : approach.BeI, new()
	{
		public void vow(ApproachI obj)
		{
			nilnul.obj.vow_.True.Singleton.vow( nilnul.Singleton1<TBe>.Instance.be(obj));
		}


		static public Vow<TBe> Singleton
		{
			get
			{
				return nilnul.Singleton1<Vow<TBe>>.Instance;
			}
		}

	}
}
