using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.of_.binary_
{
	public class Divide :
		EachAssumeExtA
		,
		real.ext.op_.BinaryI
		,
		real.ext.of_.Binary4dblI

	{
		public ExtI op_negInfDivide(ext_.Bare par1)
		{
			var sign = nilnul.num.real._SignX.BitNul(par1.val);
			if (sign is null)
			{
				throw new DivideByZeroException($"{par1}, being nil, cannot divide ");
			}
			if (sign.Value)
			{
				return ext_.inf_.Neg.Singleton;
			}
			return ext_.inf_.Pos.Singleton;
		}

		public ExtI op_posInfDivide(ext_.Bare par1)
		{
			return op_.unary_.Neg.Singleton.op(
				op_negInfDivide(par1)
			);
		}

		public ExtI op(ext_.InfI par, ext_.Bare par1)
		{

			switch (par)
			{
				case ext_.inf_.Neg negInf:
					return op_negInfDivide(par1);


				default:
					break;
			}

			return op_posInfDivide(par1);
		}

		public ExtI op(ExtI par, ext_.Bare par1)
		{

			switch (par)
			{
				case ext_.InfI inf:
					return op(inf, par1);

				case ext_.Bare bare:
					return new ext_.Bare(
						nilnul.num.real.co_.divisible._DivX.Bind(bare.val, par1.val)
					);
				default:
					break;
			}
			throw new UnexpectedReachException();

		}


		public ExtI op(ExtI par, ext_.InfI par1)
		{

			switch (par)
			{
				case ext_.InfI inf:
					throw new InvalidOperationException($"infinity / infinity is undeterministic");

				default:
					break;
			}
			return new ext_.Bare(0);

		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="par"></param>
		/// <param name="par1"></param>
		/// <returns></returns>
		public ExtI op(ExtI par, ExtI par1)
		{
			switch (par1)
			{
				case ext_.InfI inf
				:
					return op(par, inf);
				case ext_.Bare bare:
					return op(par, bare);
				default:
					break;
			}
			throw new UnexpectedReachException();

			///this is wrong, as 1/inf is nil and inf* nil =nil, but we expect inf
			//return Multi.Singleton.op(
			//	par
			//	,
			//	op_.unary_.Invert.Singleton.op(par1)
			//);

		}

	

		public override double _op_01ext(double a, double b)
		{
			//if (b==0)
			//{
			//	//exception
			//}
			/*
			var r = a/ b;
//if (double.IsNaN(r))
//			{
//				throw 
//			}
			*/
	
			var r = a / b;
			if (double.IsNaN(r) )
			{
				throw new Exception($"{b} is nil or ({a} and {b} are both inf) such that the result is undef|indeterminate;");
			}
			

			return r;
		}

		static public Divide Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Divide>.Instance;
			}
		}

	}
}
