using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider.subsumed_.add_._generizedBinom
{
	public class Term
		:
		nilnul.num.real.stream_.SliderA
	{

		

		private nilnul.num.real.stream_.slider_.geometric_.Std _geometric;

		public nilnul.num.real.stream_.slider_.geometric_.Std geometric
		{
			get { return _geometric; }
			set { _geometric = value; }
		}

		private nilnul.num.real.stream_.slider_.Combinate _combinate;

		public nilnul.num.real.stream_.slider_.Combinate combinate
		{
			get { return _combinate; }
			set { _combinate = value; }
		}



		public override RealI current => _geometric.current.ToReal()*_combinate.current;

		public Term(nilnul.num.RealI addendInBase, nilnul.num.RealI index )
			
		{
			_combinate = new slider_.Combinate(index);
			_geometric = new slider_.geometric_.Std(addendInBase);
		}
		

		public override void moveNext()
		{
			_geometric.moveNext();
			_combinate.moveNext();
		}
	}
}
