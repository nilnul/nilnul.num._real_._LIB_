using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using nilnul.num.real.op;

namespace nilnul.num.real.duo.op
{
	[Obsolete(null, true)]

	public  class Root
    {

        static public R Eval(R base_, num.natural.__bigint.be.Positive.Asserted root)
        {


            return new Expr(base_, root);

        }
        static public R Eval(R base_, BigInteger index)
        {
            return Eval(base_,
                new num.natural.__bigint.be.Positive.Asserted(
                index)
            );
        }

        static public Expr Call(R base_, num.natural.__bigint.be.Positive.Asserted index)
        {
            return new Expr(base_, index);
        }


        static public Expr Call(R base_, BigInteger index)
        {
            return new Expr(base_, index);
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

            private num.natural.__bigint.be.Positive.Asserted _index;

            public num.natural.__bigint.be.Positive.Asserted index
            {
                get { return _index; }
                set { _index = value; }
            }



            public Expr(R base_, num.natural.__bigint.be.Positive.Asserted index)

            {
                this._base = base_;
                this.index = index;
                _inversionExpr__set();



            }

            public Expr(R base_, BigInteger index)
                : this(base_, new num.natural.__bigint.be.Positive.Asserted(index))

            {




            }


            private R _inverseExpr;


            private void _inversionExpr__set()
            {
                _inverseExpr =new real.op.Inverse_posConverge2interval.Expr(
                    new real.be.NotZero.Asserted(
                        new real.op.Pow_posConverge2interval.Expr(_base,_index.val) 
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
