using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.limit.sow;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using N = nilnul._num.bigint.op.Abs.Ed;

namespace nilnul.num.real.single
{
	/// <summary>
	/// </summary>
	public class SqrtOfN:

		num.RealI
	{
		private N _arg;

		public N arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public SqrtOfN(N q)
		{
			_arg = q;
			_cofinal=new nilnul.num._real.limit.cofinal.single.SqrtOfN(_arg);
		}

		private nilnul.num._real.limit.cofinal.single.SqrtOfN _cofinal;

		public nilnul.num._real.limit.cofinal.single.SqrtOfN cofinal
		{
			get { return _cofinal; }
			private set { _cofinal = value; }
		}

		public ConfluentI confluent
		{
			get
			{
				return _cofinal;
				throw new NotImplementedException();
			}
		}

		public nilnul.num._real.LimitI limit {
			get {
				return _cofinal.limit;
			}
		}

		public override string ToString()
		{
			return nilnul.num.real.op.Sqrt1.CHAR+arg.ToString();
		}


	}


}
