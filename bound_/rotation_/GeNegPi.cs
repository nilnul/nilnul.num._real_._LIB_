using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.rotation_
{
	static public class _GeNegPiX
	{
		static public nilnul.num.real.Bound Create(nilnul.num.real.Border right) {
			return new Bound(

				nilnul.num.real.Border.CreateClose( - nilnul.num.real_.TauX.Half)
				,
				right
			);
		}

		static public nilnul.num.real.Bound CreateLt(nilnul.num.RealI right) {
			return Create(
				nilnul.num.real.Border.CreateOpen( right)
				
			);
		}
		static public nilnul.num.real.Bound CreateLt(int right)
		{
			return CreateLt(
				new nilnul.num.real_.Quotient(right)

			);
		}

		static public nilnul.num.real.Bound CreateLe(nilnul.num.RealI right) {
			return Create(
				nilnul.num.real.Border.CreateClose( right)
				
			);
		}

		static public nilnul.num.real.Bound CreateLe(int right)
		{
			return CreateLe(
				new nilnul.num.real_.Quotient(right)
			);
		}

		static public nilnul.num.real.Bound CreateLtNegQuarter() {
			return CreateLt(
				-nilnul.num.real_.TauX.Quarter
			);
		}



		static public nilnul.num.real.Bound CreateLeNegQuarter() {
			return CreateLe(
				-nilnul.num.real_.TauX.Quarter
			);
		}

		static public nilnul.num.real.Bound CreateLtNil() {
			return CreateLt(

				0
			);
		}



		static public nilnul.num.real.Bound CreateLeNil() {
			return CreateLe(
				0
			);
		}




		static public nilnul.num.real.Bound CreateLtQuarter() {
			return CreateLt(

				nilnul.num.real_.TauX.Quarter
			);
		}



		static public nilnul.num.real.Bound CreateLeQuarter() {
			return CreateLe(
				nilnul.num.real_.TauX.Quarter
			);
		}



		static public nilnul.num.real.Bound CreateLtPi() {
			return CreateLt(
				nilnul.num.real_.TauX.Half
			);
		}

		static public nilnul.num.real.Bound CreateLePi() {
			return CreateLe(
				nilnul.num.real_.TauX.Half
			);
		}



		static public nilnul.num.real.Bound CreateLtTau() {
			return CreateLt(
				nilnul.num.real_.Tau.Singleton
			);
		}

		static public nilnul.num.real.Bound CreateLeTau() {
			return CreateLe(
				nilnul.num.real_.Tau.Singleton
			);
		}



	}
}
