using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.interval.s.disjoint.ordered
{
	public class Collapse
	{
		static public List<Interval3> _Eval(List<Interval3> intervalsOrdered)
		{



			throw new NotImplementedException();
		}

		static public List<Interval3> _Merge(List<Interval3> collapsedOrdered, Interval3 incoming)
		{

			var r = new List<Interval3>();
			int i = 0;
			var jointS = new List<Interval3>();

			for (; i<collapsedOrdered.Count &&  num.real.double_.interval.duo.MutualPosition.Eval( collapsedOrdered[i],incoming)<0; i++)
			{

					r.Add(collapsedOrdered[i]);

					
				
			}


			for (; i < collapsedOrdered.Count &&  num.real.double_.interval.duo.MutualPosition.Eval( collapsedOrdered[i],incoming)==0; i++)
			{
				
				jointS.Add(collapsedOrdered[i]);

			}

		
			r.Add(
				_Clamp_mayHave(jointS, incoming)	
			);

			


			for (; i < collapsedOrdered.Count   ; i++)
			{
				r.Add(collapsedOrdered[i]);

			}
			

			return r;




			throw new NotImplementedException();

		}
		static public Interval3 _Clamp_mayHave(List<Interval3> intersectedS_ordered, Interval3 incoming)
		{
			if (intersectedS_ordered.Count==0)
			{
				return incoming;
			}

			return 
				new Interval3(
					nilnul.order.comparer.bound.comparer.Lower_elementComparerDefault<_ext.ExtI,ext.Ord,ext.Bound>.Min(intersectedS_ordered.First().lower,incoming.lower)
					,
					nilnul.order.comparer.bound.comparer.Upper_elementComparerDefault<_ext.ExtI,ext.Ord,ext.Bound>.Max(intersectedS_ordered.Last().upper,incoming.upper)

				)
			;

			throw new NotImplementedException();

		}

		static public Interval3 _Clamp(List<Interval3> intersectedS_ordered_has, Interval3 incoming)
		{


			return 
				new Interval3(
					nilnul.order.comparer.bound.comparer.Lower_elementComparerDefault<_ext.ExtI,ext.Ord,ext.Bound>.Min(intersectedS_ordered_has.First().lower,incoming.lower)
					,
					nilnul.order.comparer.bound.comparer.Upper_elementComparerDefault<_ext.ExtI,ext.Ord,ext.Bound>.Max(intersectedS_ordered_has.Last().upper,incoming.upper)

				)
			;

			throw new NotImplementedException();

		}

	}
}
