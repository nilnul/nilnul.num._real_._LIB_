using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;


using nilnul._stream_;

namespace nilnul.num.real.stream_
{
	/// <summary>
	/// √(1+√(1+√(1+...)))
	/// The limit is Golden Ratio.
	/// </summary>
	public class Sqrt_1plus__recur
		: nilnul.obj._stream_.NextI<R>
	{

		private R _pre = new nilnul.num.real_.Quotient(1);

		public R pre
		{
			get { return _pre; }
			set { _pre = value; }
		}

		static public readonly R One = new nilnul.num.real_.Quotient(1);

		public R next()
		{

			return _pre = nilnul.num.real_.nonneg.op_.unary_.Sqrt.Singleton.op(
				nilnul.num.real.op_.binary_.Add.Singleton.op(
					1
					,
					nilnul.num.real_.nonneg.op_.unary_.Sqrt.Singleton.op(_pre)

				)
			);
			//throw new NotImplementedException();
		}


	}
}
