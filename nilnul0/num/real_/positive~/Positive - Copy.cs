using nilnul.num._real.approach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach.generator;
using nilnul.num._real.approach.generator_;

namespace nilnul.num.real_
{
	public interface PositiveI
		:nilnul.num.RealI2
	{

		nilnul.num._real.approach.generator_.PositiveI choice { get; }

	}

	public class Positive : num.real.be.En<num.real.be_.Positive>
		,PositiveI
	{
		private num._real.approach.generator_.Positive _generator;

		public num._real.approach.generator_.Positive generator
		{
			get { return _generator; }
			set { _generator = value; }
		}

		public _real.approach.generator_.Positive choice
		{
			get
			{
				return _generator;
				//throw new NotImplementedException();
			}
		}

		_real.approach.generator_.PositiveI PositiveI.choice
		{
			get
			{
				return choice;
				//throw new NotImplementedException();
			}
		}

		GeneratorI CofinalI.choice
		{
			get
			{
				return choice;
				//throw new NotImplementedException();
			}
		}

		public Positive(num.RealI2 val) : base(val)
		{
			_generator = new nilnul.num._real.approach.generator_.Positive(val.choice);



		}

		public Positive(int i):this(
			new nilnul.num.real_.Quotient(i)
		)
		{

		}






	}


}
