using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.convergent.co
{
	public abstract class AlesceA : nilnul.obj.Box<convergent.Co>
		,
		stream_.ConvergentI
	{
		public AlesceA(Co val) : base(val)
		{
		}

		public abstract RealI limit { get; }

		public abstract RealI next();
	}
}
