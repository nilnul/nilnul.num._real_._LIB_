using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using nilnul.num._quotient.fraction.op;
	using nilnul.num.quotient.stream_.slider_;
	using Q1 = nilnul.num.Quotient1;

namespace nilnul.num.real.stream_.slider_
{

		public class Repeater :
			nilnul.num.real.stream_.SliderA
			//SliderI2
			,
			nilnul.obj.stream_.slider_._FuncI

		{
			public Repeater(RealI q)
			{
				_current = q;
			}
			private RealI _current;
			public override RealI current
			{
				get
				{
					return _current;
					//throw new NotImplementedException();
				}
			}

			public override void moveNext()
			{
				return;
				//throw new NotImplementedException();
			}

			public void setIndex(nilnul.Num1 num)
			{

			}

			public void moveNext(nilnul.Num1 num)
			{

			}


		}
	}
