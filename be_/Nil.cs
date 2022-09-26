using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = nilnul.num.RealI6;

namespace nilnul.num.real.be_
{
	[Obsolete()]

	[DebuggerDisplay("if the argument is zero, it may return (for example, if the sequence is a quotient whose interval is set [0,0]); or it may perpetual (for example, if the sequence is 1/n)")]
	static public class _NilX1
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="real"></param>
		/// <returns></returns>
		/// <exception cref="">
		/// if the argument is zero, it may return (for example, if the sequence is a quotient whose interval is set [0,0]); or it may perpetual (for example, if the sequence is 1/n)
		/// if the argumentis not zero, it always return.
		/// </exception>
		/// 
		[MayPerpetual()]
		static public bool Be(A approach)
		{
#warning may perpetual if the argument is converging zero like 1/n
			return nilnul.num.real._SignX2.BitNul(approach) ==null;
			//return approach.range.containsZero();
		}
	}

	public class Nil1 : nilnul.num.real.BeI2
	{
		public bool be(A obj)
		{
			return _NilX1.Be(obj);
		}

		static public Nil1 Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nil1>.Instance;
			}
		}

	}
}