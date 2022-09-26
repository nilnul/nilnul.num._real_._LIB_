using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be
{

	[Obsolete(nameof(real.be.anto_))]
	public class Anto<TBe>:nilnul.obj.be.Anto<nilnul.num.RealI, TBe>
		,nilnul.num.real.BeI
		where TBe:nilnul.num.real.BeI,new()

	{
	}
}
