using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using nilnul.num.real.op;

namespace nilnul.num.real.solo.op
{
    public partial class SinQ
    {

        


     

        public class Expr
            : R
        {
            private Q _base;

            public Q base_
            {
                get { return _base; }
                set { _base = value; }
            }

         


            public Expr(Q base_)

            {
                this._base = base_;



            }



			public Q accumulated=0;

			public Q radius {
				get {
					return nilnul.num.rational.op.DivideX.Inverse(
						num.natural.stream.Odd.GetItem(nextIndex)
					);
				}
			}

			public BigInteger nextIndex=0;

			public int nextSign = 1;




            public rational.bound.pair.be.Nonempty.Asserted interval
            {
                get
                {
					return rational.bound.pair.be.Nonempty.Asserted.CreateNeighbor(accumulated, radius);

                    throw new NotImplementedException();

                }
            }

            public void converge(rational.be.Positive.Asserted diameter)
            {
				

				while (diameter.val>radius)
				{

					accumulated += nilnul.num.rational.op.DivideX.Inverse(
						num.natural.stream.Odd.GetItem(nextIndex)
					) *  nextSign;

					nextIndex++;
					nextSign *= -1;

				}
				
                return;
                throw new NotImplementedException();
            }
        }
    }
}
