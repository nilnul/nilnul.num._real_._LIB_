using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.ieee.str_.enumerable.be_;

namespace nilnul.num.ieee.str_.enumerable_.startedDif.op_
{
	public class Sort
		: nilnul.obj.OpI<enumerable.be_.StartedDif.En>
	{
		private IComparer<double> _comparer;

		public IComparer<double> comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}

		public Sort(
			IComparer<double> comparer
			
		)
		{
			_comparer = comparer;

		}
		public StartedDif.En eval(StartedDif.En arg)
		{

			
			return new StartedDif.En(
				arg.avowed.OrderBy(x=>x,_comparer)	
			);

		}

	

		public class Ed : nilnul.obj.op.Ed<StartedDif.En, Sort>
		{
			public Ed(StartedDif.En input, Sort op) : base(input, op)
			{

			}

			
		}


	}
}
