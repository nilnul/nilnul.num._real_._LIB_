using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.op_.binary_
{
	public class Multi : real.ext.op_.BinaryI
	{
		public ExtI op_multiPosInf(ext_.Bare bare)
		{

			var sign = nilnul.num.real.Sign.Singleton.sign(bare.val);
			if (sign is null)
			{
				return new ext_.Bare(0);
			}
			if (sign.Value)
			{
				return ext_.inf_.Pos.Singleton;
			}

			return ext_.inf_.Neg.Singleton;

		}

		public ExtI op_multiNegInf(ext_.Bare bare)
		{


			return unary_.Neg.Singleton.op(
				op_multiPosInf(bare)
			);

		}

		public ExtI op_multiPosInf(ExtI par1)
		{
			switch (par1)
			{
				case ext_.inf_.Neg neg:
					return ext_.inf_.Neg.Singleton;
				case ext_.Bare bare:
					return op_multiPosInf(bare);
				case ext_.inf_.Pos pos:
					break;
					;
				default:
					break;
			}
			return ext_.inf_.Pos.Singleton;

		}

		public ExtI op_multiNegInf(ExtI par1)
		{
			return unary_.Neg.Singleton.op(
				op_multiPosInf(par1)
			);


		}


		public ExtI op(ExtI par, ext_.Bare par01)
		{
			switch (par)
			{
				case ext_.inf_.Neg neg:
					return op_multiNegInf(par01);

				case ext_.Bare bare:
					return new ext_.Bare(
						nilnul.num.real.op_.binary_.Multi.Singleton.op(bare.val, par01.val)
					);

				case ext_.inf_.Pos pos:
				default:
					break;
			}
			return op_multiPosInf(par01);

			throw new UnexpectedReachException();
		}




		public ExtI op(ExtI par, ExtI par1)
		{
			switch (par1)
			{
				case ext_.inf_.Neg neg:
					return op_multiNegInf(par);

				case ext_.Bare bare:
					return op(par, bare);
				case ext_.inf_.Pos pos:
				default:
					break;
			}
			return op_multiPosInf(par);

		}

		static public Multi Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Multi>.Instance;
			}
		}

	}
}
