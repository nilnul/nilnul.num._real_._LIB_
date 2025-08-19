using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be
{
	[Obsolete()]
	public class Vow_1<TBe>
		:nilnul.obj.be.Vow2<nilnul.num.RealI2,TBe>
		,
		nilnul.num.real.VowI_1
		where TBe:nilnul.num.real.BeI,new()
	{

	}
}
