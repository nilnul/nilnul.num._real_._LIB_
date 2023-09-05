using nilnul.num.real.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.stream_.slider_.arithmetic_.std
{
	static public class _CumulusX
	{
		static public nilnul.num.RealI SumUp2numero(
			nilnul.num.Real rate
			,
			nilnul.Num1 numero
		) {


			return rate * nilnul.num.stream_.natural.Cumulus.SumUp2numero(numero);
		}

		static public nilnul.num.RealI SumBeforeNumero(
			nilnul.num.Real rate
			,
			nilnul.Num1 numero
		) {


			return rate * nilnul.num.stream_.natural.Cumulus.SumBeforeNmero(numero);
		}


		static public nilnul.num.RealI SumUp2numero(
			nilnul.num.RealI rate
			,
			nilnul.Num1 numero
		) {

			return SumUp2numero(rate.ToReal(),numero);
		}

	}

	/// <summary>
	/// 
	/// </summary>
	public class Cumulus : nilnul.num.real.stream_.slider.cumulus_.Series
	{
		public Cumulus( R rate) : base(new Std(rate))
		{
		}
	}
}
