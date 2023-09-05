using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;

namespace nilnul.num._real.approach_.tau_._one__Plus__OddSince3_PositiveSquare___UnderEight.oddSince3_PositiveSquare
{
	public class PlusOne_UnderEight
		: nilnul.num.quotient.SliderI
	{
		private OddSince3_PositiveSquare _underEight=new OddSince3_PositiveSquare();

		public OddSince3_PositiveSquare underEight
		{
			get { return _underEight; }
			set { _underEight = value; }
		}

		public Simplify.Ed1 current
		{
			get
			{
				return 8 / (1+underEight.current);
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			underEight.moveNext();
			//throw new NotImplementedException();
		}
	}
}
