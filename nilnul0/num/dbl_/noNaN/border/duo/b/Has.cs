using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.double_.b;
using NoNan = nilnul.num.real.double_.b.NoNaN.Asserted;

namespace nilnul.num.real.double_.noNaN.border.duo.b
{
	public class Has
		: nilnul.obj.BI<Duo>

	{
		public bool be(Duo d)
		{
			return d.lower.mark.val < d.upper.mark.val || nilnul.comparer.border.Eq_ComparerDefault<NoNan,Comparer,Border>.Singleton.Equals(d.lower,d.upper);


			throw new NotImplementedException();
		}


		public class Asserted
			
			:nilnul.obj.Asserted<Duo,Has>
			,
			nilnul.collection.ContainsI<NoNan>
			,nilnul.collection.ContainsI<double>
			
		{
			public Asserted(Duo duo)
				:base(duo)
			{

			}

			public Asserted(double a,bool openFalseCloseTrue,  double b, bool openFalseCloseTrueB)
				:this(
					  new Duo(
					a,openFalseCloseTrue	,b,openFalseCloseTrueB
					)
					 )
			{
				
			}

			public bool contains(double item)
			{
				return contains(new NoNan(item));
				throw new NotImplementedException();
			}

			public bool contains(NoNan item)
			{
				return val.contains(item);

				throw new NotImplementedException();
			}


			public void assertContain(double x) {
				nilnul.Assert1.True(contains(x));
			}

			static public Asserted CreateClose(
				double lower, double upper
				) {

				return new Asserted(lower, true, upper,true);

			}

			static public Asserted CreateClopen(
				double lower, double upper
				) {

				return new Asserted(lower, true, upper,false);

			}

			static public void AssertCloseContain(double lower, double upper, double x) {

				CreateClose(lower, upper).assertContain(x);

			}


		}
	}
}
