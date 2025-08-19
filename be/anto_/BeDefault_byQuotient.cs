using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be.anto_
{

	public class BeDefault_byQuotient<TBe>
		:
		real.be.Anto_byQuotient

		where TBe : nilnul.obj.BeI_ofIn<num.RealI_onQuotient>, new()
	{
		public BeDefault_byQuotient() : base(
				 nilnul._obj.typ_._UnisonX<TBe>.Unison
		)
		{
		}


		static public BeDefault_byQuotient<TBe> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<BeDefault_byQuotient<TBe>>.Unison;
			}
		}



	}
}
