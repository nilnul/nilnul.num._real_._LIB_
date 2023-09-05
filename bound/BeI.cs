using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound
{
	public interface BeI
		:nilnul.obj.BeI1< nilnul.num.real.BoundI>
	{

	}
	public class Be :
		nilnul.obj.Be1<nilnul.num.real.BoundI>
		,
		BeI
	{
		public Be(Func<BoundI, bool> func) : base(func)
		{
		}

		public Be(Predicate<BoundI> predicate) : base(predicate)
		{
		}
	}
}
