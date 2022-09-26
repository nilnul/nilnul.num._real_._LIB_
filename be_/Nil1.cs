using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;

namespace nilnul.num.real.be_
{
	public class Nil
		: nilnul.num.real.BeI
	{

		[MayPerpetual]
		public bool be(num.RealI real)
		{
			#region MyRegion
				///already done in Eq
				///
				/*
				if (real is nilnul.num.real.op_.binary_._add.Ret added)
				{
					if (added.arg1 is num.real.op_.unary_._neg.Ret neged)
					{
						if ( neged.arg )
						{

						}
					}
				}
				*/
			#endregion
			while (true)
			{
				if (
					real.current.upper.mark< 0
				)
				{
					return false;

				}
				if (
					
					real.current.lower.mark> 0
					
				)
				{
					return false;
				}

				/// upper >= 0, lower <=0
				/// 

				if (
					nilnul.num.quotient.Eq2.Singleton.Equals(
						real.current.upper.mark,real.current.lower.mark
					) 
				)
				{
					return true;

				}
				real.Clamp1K();

			}
			//throw new NotImplementedException();
		}


		static public Nil Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nil>.Instance;
			}
		}


	}
}
