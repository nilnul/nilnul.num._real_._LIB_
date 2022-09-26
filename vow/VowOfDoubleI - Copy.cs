using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	[Obsolete(nameof(num.real.VowDblI))]
	public interface VowOfDoubleI
		:
		num.real.VowDblI
		,
		nilnul.obj.VowI2<double>
	{
	}
}
