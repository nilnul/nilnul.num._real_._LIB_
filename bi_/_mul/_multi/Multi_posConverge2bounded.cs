using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;

namespace nilnul.num.real.op
{
	public partial class Multi_posConverge2bounded
	{
		static public real.RealI_posConverge2NonEmpty Eval(real.RealI_posConverge2NonEmpty a, real.RealI_posConverge2NonEmpty b)
		{

			return new Expr(a, b);

			throw new NotImplementedException();

		}
		static public real.RealI_posConverge2NonEmpty Eval(Q a, real.RealI_posConverge2NonEmpty b)
		{
			return Eval(
				new Rational_posConverge2Bounded(a),b
				
			);

		}

		static public R Square(R a)
		{

			return new Expr(a, a);

			throw new NotImplementedException();

		}



		public partial class Expr 
			: 
			real.RealI_posConverge2NonEmpty
		{
			private real.RealI_posConverge2NonEmpty _first;

			public real.RealI_posConverge2NonEmpty first
			{
				get { return _first; }
				set { _first = value; }
			}

	

			private real.RealI_posConverge2NonEmpty _second;

			public real.RealI_posConverge2NonEmpty second
			{
				get { return _second; }
				set { _second = value; }
			}



			public Expr(real.RealI_posConverge2NonEmpty a, real.RealI_posConverge2NonEmpty b)
			{
				this.first = a;
				this.second = b;

			}

			public Expr(Q a, real.RealI_posConverge2NonEmpty b)
				:this(
					new real.Rational_posConverge2Bounded(a),b	 
				)
			{
				

			}


		

		

		

			public rational.bound.pair.be.Nonempty.Asserted interval
			{
				get {

					return r.bound.pair.be.Nonempty.Asserted.Multi(_first.interval, _second.interval);
					
					throw new NotImplementedException(); 
				
				}
			}

			public void converge(rational.be.Positive.Asserted diameter)
			{
				//Q firstDiameter = first.interval.diameter, secondDiameter=second.interval.diameter;

				bool _f=true, _s=true;

				while (interval.diameter>diameter.val)
				{
					if (_f)
					{
						var fDiameter = first.interval.diameter;
						if (fDiameter==0)
						{
							_f = false;
						}
						else
						{
							_first.converge(
								new r.be.Positive.Asserted(
								fDiameter / 2
								)
						
							);

						}

						

					}
					
					if (_s)
					{
						var sDiameter = second.interval.diameter;
						if (sDiameter==0)
						{
							_s = false;
						}
						else
						{
							_second.converge(
								new r.be.Positive.Asserted(
								sDiameter / 2
								)
						
							);

						}

						

					}
				
				}

				return;
				throw new NotImplementedException();
			}
		}
	}
}
