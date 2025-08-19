using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic
{
	/// <summary>
	/// used in factoring for <see cref="algebraic.Frac"/>
	/// </summary>
	/// alias:
	///		indicant
	public class Ponent
	{
		private Algebraic _basis;

		public Algebraic basis
		{
			get { return _basis; }
			set { _basis = value; }
		}

		private BigInteger _index;

		public BigInteger index
		{
			get { return _index; }
			set { _index = value; }
		}

		public Ponent(
			Algebraic basis
			,
			BigInteger index
		)
		{
			_basis = basis;
			_index = index;
		}

		public Ponent(Algebraic ponent)
			:this(ponent,1)
		{
		}

		public Ponent(VarI v):this(new Algebraic(v))
		{
		}
	}
}
