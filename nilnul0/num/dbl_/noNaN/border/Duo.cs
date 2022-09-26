using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoNaN = nilnul.num.real.double_.b.NoNaN.Asserted;

namespace nilnul.num.real.double_.noNaN.border
{


	public class Duo
		:nilnul.comparer.border.Duo_ComparerDefault<NoNaN,Comparer, Border>
	{
		public Duo(Border lower, Border upper)
			:base(lower,upper)
		{

		}

		public Duo(double a, bool a_openF, double b, bool bBool)
			:this(
				new Border(a,a_openF)
				 ,
				new Border(b,bBool)	 
			 )
		{

		}
	}
}
