using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.math.number.complex.real;

namespace nilnul.math.algebra.function
{
	/// <summary>
	/// compare two real exprs.
	/// </summary>
	static public partial class EqualX
	{
		static public bool? IsEqual(this RealExprI a,RealExprI b) {

			RealExprI a2=a.simplify();
			RealExprI b2=b.simplify();
			if (
				a2.GetType().GetGenericTypeDefinition()==typeof(Real<>)
				&&
				b2.GetType().GetGenericTypeDefinition()==typeof(Real<>)
				)
			{
				return (decimal)( a2.GetType().GetProperty("value").GetValue(a2,null))
					==
				 (decimal)(b2.GetType().GetProperty("value").GetValue(b2, null));
			}

			return null;
		}
		
	}
}
