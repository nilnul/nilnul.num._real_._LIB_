using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.rotation_
{
	static public class _PositiveX
	{
		static public nilnul.num.real.Bound CreateLtQuarter() {
			return bound_._PositiveX.CreateOpen(
				nilnul.num.real_.TauX.Quarter
			);
		}

		static public nilnul.num.real.Bound CreateLeQuarter() {
			return bound_._PositiveX.CreateClose(
				nilnul.num.real_.TauX.Quarter
			);
		}

		static public nilnul.num.real.Bound CreateLtPi() {
			return bound_._PositiveX.CreateOpen(
				nilnul.num.real_.TauX.Half
			);
		}

		static public nilnul.num.real.Bound CreateLePi() {
			return bound_._PositiveX.CreateClose(
				nilnul.num.real_.TauX.Half
			);
		}



		static public nilnul.num.real.Bound CreateLtTau() {
			return bound_._PositiveX.CreateOpen(
				nilnul.num.real_.Tau.Singleton
			);
		}

		static public nilnul.num.real.Bound CreateLeTau() {
			return bound_._PositiveX.CreateClose(
				nilnul.num.real_.Tau.Singleton
			);
		}



	}
}
