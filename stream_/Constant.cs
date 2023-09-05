using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.stream.be_.piable;
using nilnul.num.real.stream.be_.piable.vow;
using nilnul.obj_.xpn_;

namespace nilnul.num.real.stream_
{
	/// <summary>
	/// </summary>


	public class Constant :
		nilnul.obj.Box<nilnul.num.RealI>,

		real.StreamI
	{
		public Constant(RealI val) : base(val)
		{
		}

		public RealI next()
		{
			return boxed;
		}
	}
}
