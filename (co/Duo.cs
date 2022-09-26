using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.num.real
{
	public class Co : nilnul.obj.Co<R>
	{
		public Co(R item1, R item2) : base(item1, item2)
		{
		}

		public nilnul.num.Real r {
			get { return new num.Real(Item1); }
		}

		public nilnul.num.Real r1 {
			get { return new num.Real(Item2); }
		}
	}
}
