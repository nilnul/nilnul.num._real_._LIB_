using nilnul.num.natural;
using nilnul.num.rational;
using System;
using System.Numerics;
using Q = nilnul.num.quotient.Q;

using q = nilnul.num.quotient;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;

namespace nilnul.num._real.limit.eg
{
	public partial class E:
		
		CauchyI
	{

		BigInteger termIndex = 0;
		BigInteger termIndexFactorial = 1;



		BigInteger nextTermIndex = 1;
		BigInteger nextTermIndexFactorial = 1;

		Q term=1;	///1/termIndexFactorial

		Q residue = 3;



		private Q _accumulated=1;

	
		private q.ext.border.duo.be.Bound.Asserted _interval= q.ext.border.duo.be.Bound.Asserted.CreateOpen(0,3);

		

		static public E Singleton = SingletonByDefault<E>.Instance;

		public quotient.ext.border.duo.be.Bound.Asserted bound
		{
			get
			{
				return _interval;
				throw new NotImplementedException();
			}
		}


		public void converge(Positive.Asserted diameter)
		{

			while (_interval.diameter>diameter.val)
			{

				termIndex++;


				nextTermIndex++;

				termIndexFactorial = nextTermIndexFactorial;


				nextTermIndexFactorial *= nextTermIndex;



				term /= termIndex;

				_accumulated += term;

				residue=Q.Divide(3,nextTermIndexFactorial);

				_interval = new q.ext.border.duo.be.Bound.Asserted(
					new q.ext.Border(false,_accumulated)
					,new q.ext.Border(false,_accumulated+residue)
				);


				
			}

			return;




			throw new NotImplementedException();
		}
	}
}
