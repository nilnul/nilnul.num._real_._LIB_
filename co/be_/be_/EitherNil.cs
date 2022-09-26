using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using q = nilnul.num.quotient;
using R = nilnul.num.RealI;


namespace nilnul.num.real.co.be_
{
	public class EitherNil : num.real.co.BeI
	{
		/// <summary>
		/// </summary>
		/// <param name="duo"></param>
		/// <returns></returns>
		public bool be( Co duo)
		{

			return be(duo.Item1,duo.Item2);

		}
		public bool be(R arg, R arg1)
		{

			//var arg = duo.Item1;
			//var arg1 = duo.Item2;




			///quotients will converge early.
			while (
				real.be_.bound_.InvolveNil.Singleton.be(arg)
				||
				real.be_.bound_.InvolveNil.Singleton.be(arg1)
			)
			{
				if (real.be_.bound_.Nil.Singleton.be(arg))
				{
					return true;

				}
				if (real.be_.bound_.Nil.Singleton.be(arg))
				{
					return true;

				}

				arg.squeeze(
					new quotient_.Positive1(
						arg.current.diameter / 2
					)
				);


				arg1.squeeze(
					new quotient_.Positive1(
						arg1.current.diameter / 2
					)
				);

			}



			return false;

		}

		static public EitherNil Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<EitherNil>.Instance;
			}
		}

	}
}
