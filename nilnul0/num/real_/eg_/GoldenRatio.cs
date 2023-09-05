using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.rational;
using System.Numerics;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using R = nilnul.num.RealI;
using ApproachI1 = nilnul.num.RealI;

namespace nilnul.num.real_
{

	/// <summary>
	/// </summary>
	/// <remarks>
	/// Phi is the golden ration of 1.618....
	/// 
	/// see also
	///		Psi is the  1-Phi= -1/phi =-0.618...
	/// 
	/// </remarks>

	public class GoldenRatio
		:
					ApproachI1

	{


		private ApproachI1 expr=real.op_.binary_.Add.Op(
			nilnul.num.real_.Quotient.CreateHalf()
			,
			nilnul.num.real.op_.unary_._ScaleX.Halve(
				nilnul.num.real.op_.unary_.Sqrt.Singleton.op(
				5u
				)
			)
		);

	

		public void squeeze(num.quotient_.Positive1 diameter)
		{
			expr.squeeze(diameter);
		}

		

		public num.quotient.bound_.Closed current
		{
			get
			{
				return expr.current;
			}
		}


		static public GoldenRatio Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<GoldenRatio>.Instance;
			}
		}

	}
}
