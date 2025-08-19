using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real;
using nilnul.num.quotient.stream_.bound_;

namespace  nilnul.num.real_
{

	public class Euler : _real_.ChoiceI1
	{
		public Euler( ) 
		{
		}

		public num.quotient.stream_.bound_.CauchyI choice => new nilnul.num.quotient.stream_.bound_.cauchy_.Euler();
	}
}
