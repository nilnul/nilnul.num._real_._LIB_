using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.convergent.co
{
	/*设limAn=a,limBn=b，求证lim（(A1Bn+A2Bn-1+...+AnB1)/n)=ab
	 
一般的解法就是令An=a+an，an->0当n->无穷时，Bn也可以类似处理，接下来把ab移到左边，用ε—N语言进行处理就可以了

*/
	public class InnerProd :

		nilnul.num.real.stream_.SliderA
		,
		nilnul.num.real.stream_.ConvergentI
	{
		public InnerProd(Co val)
		{
			stock = new stream.stock_.General(val.component);
			stock1 = new stream.stock_.General(val.component1);
			stock.moveNext();		// or else : we have div/0 erro.
			stock1.moveNext();
			//_co = val;
			_limit= val.Item1.limit.ToReal() * val.Item2.limit;

		}

		//num.real.stream_.convergent.Co _co;

		nilnul.num.real.stream.stock_.General stock;
		nilnul.num.real.stream.stock_.General stock1;

		private RealI _limit;
		public RealI limit => _limit;

		public override RealI current {
			get
			{
				var reversed = stock1.current.AsEnumerable().Reverse();

				return nilnul.num.real.str.co_.sameLen._InnerProductX._RealI_assumeSameLength(
					stock.current,
					reversed
				).ToReal()/stock.current.Count
				;
				
			}
		}

	

		public override void moveNext()
		{
			stock.moveNext();
			stock1.moveNext() ;
		}
	}
}
