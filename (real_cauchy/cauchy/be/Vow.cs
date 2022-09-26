using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = nilnul.num._real.CauchyI2;
namespace nilnul.num._real.cauchy.be
{
	public class Vow<TBe>:nilnul.obj.be.Vow1<C,TBe>
		,
		nilnul.num._real.cauchy.VowI
		where TBe:nilnul.num._real.cauchy.BeI,new()
	{
	}
}
