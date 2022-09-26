using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S = nilnul.num.real.stream_.SliderI;


namespace nilnul.num.real.stream_.slider.set.gregate_._prod
{
	public class Ret
		:
		real.stream_.SliderA

	{

		private IEnumerable<S> _args;

		public IEnumerable<S> args
		{
			get { return _args; }
			set { _args = value; }
		}

		public Ret(IEnumerable<S> streams)
		{
			_args = streams;

		}

		public override RealI current
		{
			get
			{
				return (
					nilnul.num.real.op_.binary_.multi.Cumulator.Singleton.accumulate(
					_args.Select(x => x.current)
				))
				;

			}
		}

		public override void moveNext()
		{
			_args.ForEach(x => x.moveNext());
		}
	}
}
