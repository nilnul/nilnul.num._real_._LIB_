using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.co.alesce_.multi_
{
	/// <summary>
	/// for standard Geometric, see nilnul.num.real.stream_.rigid.cumulus_.Multi
	/// </summary>
	public class Geometric : alesce_.Multi
	{
		public Geometric(nilnul.num.RealI head, nilnul.num.RealI rate) : base(
			new nilnul.num.real.stream_.Rigid(head)
			,
			new nilnul.num.real.stream_.rigid.cumulus_.Multi(rate)
		)
		{
		}
	}
}
