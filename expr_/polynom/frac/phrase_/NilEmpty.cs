using nilnul.num.real.expr_._algebraic.pows.prod.scaleds;
using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.seq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.frac.phrase_
{
	
	public class NilEmpty
		:

		nilnul.obj.PhraseI<algebraic.Frac>
	{
		public string phrase(Frac obj)
		{
			var numeratorTxt = obj.numerator.ToString();
			if (numeratorTxt=="0" || numeratorTxt==string.Empty)
			{
				return "";
			}

			if (obj.numerator.scaleds.Count() >= 2)
			{
				numeratorTxt = $"({numeratorTxt})";
			}
			var denominatorTxt = obj.denominator.ToString();
			if (obj.denominator.scaleds.Count() >= 2)
			{
				denominatorTxt = $"({denominatorTxt})";
			}
			if (denominatorTxt == "1")
			{
				return $"{numeratorTxt}";
			}

			return $"{numeratorTxt}/{denominatorTxt}";
		}


		static public NilEmpty Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<NilEmpty>.Instance;
			}
		}







	}
}
