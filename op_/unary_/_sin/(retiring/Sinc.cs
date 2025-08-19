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
    public partial class Sinc
    {

        static public R Eval(R base_)
        {


            return new Expr(base_);

        }
     

        static public Expr Call(R base_)
        {
            return new Expr(base_);
        }


     

        public class Expr
            : R
        {
            private R _base;

            public R base_
            {
                get { return _base; }
                set { _base = value; }
            }

         


            public Expr(R base_)

            {
                this._base = base_;
                _inversionExpr__set();



            }

           


            private R _inverseExpr;

            private void _inversionExpr__set()
            {
                _inverseExpr =new real.op.Inverse_posConverge2interval.Expr(
                    new be.NotZero.Asserted(
                        new real.solo.op.Square.Expr(_base) 
                   )
                 );

            }


            public rational.bound.pair.be.Nonempty.Asserted interval
            {
                get
                {
                    return _inverseExpr.interval;

                    throw new NotImplementedException();

                }
            }

            public void converge(rational.be.Positive.Asserted diameter)
            {
                _inverseExpr.converge(diameter);
                return;
                throw new NotImplementedException();
            }
        }
    }
}
