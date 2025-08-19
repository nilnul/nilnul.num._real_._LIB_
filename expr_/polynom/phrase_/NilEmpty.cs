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

namespace nilnul.num.real.expr_.algebraic.phrase_
{
	
	public class NilEmpty
		:

		nilnul.obj.PhraseI<Algebraic>
	{
		public string phrase(Algebraic obj)
		{
			//var c = obj.scaleds.Count();

			var numeratorTxt = obj.ToString();
			
			if (numeratorTxt=="0")
			{
				return "";
			}
			return numeratorTxt;
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
