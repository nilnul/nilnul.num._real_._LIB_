using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.ieee.str_.enumerable.be_;

namespace nilnul.num.ieee.str_.enumerable_.startedDif.op_.sort_
{


	public class ByDefault : Sort
	{
		public ByDefault() : base(ieee.Comparer.Lazy)
		{
		}
		public class Ed
			: nilnul.obj.op.Ed_opDefaultable<StartedDif.En, ByDefault>
		{

			public Ed(double[] v1)
				:this(
					new StartedDif.En(v1)
					 )
			{
			}

			public Ed(StartedDif.En input) : base(input)
			{

			}

			static public Tuple<int, int> _Search_retIndex(IEnumerable<double> _startedDifSorted, double _xWithin)
			{
				if (_startedDifSorted.Count() <=2)
				{
					if (_startedDifSorted.First() == _xWithin)
					{
						return new Tuple<int, int>(0, 0);

					}
					if (_startedDifSorted.Last()==_xWithin)
					{
						return new Tuple<int, int>(
							_startedDifSorted.Count()-1
							,
							_startedDifSorted.Count()-1	
						);
					}
					return new Tuple<int, int>(
						0,
						_startedDifSorted.Count()-1	
					);
				}

				var middle = _startedDifSorted.Count() / 2;

				var compared = nilnul.num.ieee.Comparer.Lazy.Compare(
					 _xWithin, _startedDifSorted.ElementAt(middle) 
					);

				if (compared ==0)
				{
					return new Tuple<int, int>(middle, middle);

				}
				if (compared<0)
				{
					return _Search_retIndex(
						_startedDifSorted.Take( middle+1),_xWithin	
					);

				}
				return _Search_retIndex(
					_startedDifSorted.Skip(middle), _xWithin	
				);

				

			}

			





		}
	}
}
