
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.quotient;
using nilnul.num.quotient_;
using nilnul.num.real.be_.gtOne.vow;

namespace nilnul.num.real_.positive_
{
	public interface LtOne4DblI
		
	{

		nilnul.num.real.be_.positive_.ltOne.vow.Ee4dbl ee{ get; }

	}

	public class LtOne4Dbl :
		num.real.be_.positive_.ltOne.vow.Ee4dbl
		,
		LtOne4DblI
	{


		public num.real.be_.positive_.ltOne.vow.Ee4dbl ee => this;


		public LtOne4Dbl(double val) : base(val)
		{

		}

	
		static public nilnul.num.real_.NegDbl operator -(LtOne4Dbl positive){
			return new NegDbl(
				-(positive)
			);
		}
	}


}
