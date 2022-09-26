using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.be
{

	public class Anto : nilnul.obj.be.Anto<nilnul.num.RealI>
		, nilnul.num.real.BeI

	{
		public Anto(nilnul.obj.BeI1<RealI> be) : base(be)
		{
		}
	}
}
