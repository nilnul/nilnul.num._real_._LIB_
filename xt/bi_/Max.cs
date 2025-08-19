using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.op_.binary_
{
	public class Max : real.ext.op_.BinaryI
		,
		real.ext.op_.Binary4dblI
		,
		real.ext.op_.binary_.Commutative4dblI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="par">nard</param>
		/// <param name="par1"></param>
		/// <returns></returns>
		public ExtI op(ext_.inf_.Pos par, ExtI par1) {
			return par;
		}

		public ExtI op(ext_.inf_.Neg par, ExtI par1) {
			return par1;
		}
		public ExtI op(ext_.InfI par, ExtI par1) {
			switch (par)
			{
				case ext_.inf_.Neg neg:
					return op(neg,par1);
				case ext_.inf_.Pos pos:
					return op(pos,par1);

				default:
					throw new UnexpectedReachException($"{par} shall be either neg or pos inf;");
					break;
			}
		}
		public ExtI op(ext_.Bare par, ExtI par1) {
			switch (par1)
			{

				case ext_.Bare bare:
					return new ext_.Bare(
						nilnul.num.real.op_.binary_.Min.Singleton.op(par.val,bare.val)
					);

				case ext_.InfI pos:
					return op(pos, par);
					
				default:
					break;
			}
			throw new UnexpectedReachException($"{par1} shall be either bare or inf;");
		}

		public ExtI op(ExtI par,ExtI par1)
		{
			switch (par)
			{
				case ext_.Bare bare:
					return op(bare,par1);
				case ext_.InfI pos:
					return op(pos, par1);
				default:
					break;
			}
			throw new UnexpectedReachException($"{par} shall be either bare or inf;");

		}


		public double op(double par, double par1)
		{
			return Math.Max(par, par1);
		}

		static public Max Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Max>.Instance;
			}
		}


	}
}
