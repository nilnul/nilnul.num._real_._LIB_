using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl.be
{
	public class Vow<TBe>:nilnul.obj.be.Vow2<double,TBe>
		,
		dbl.VowI
		where TBe:BeI,new()
	{
	}
}
