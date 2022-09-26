using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
using Q0 = nilnul.num.Quotient1;
using C = nilnul.num._real.CauchyI2;//.quotient.stream_.CauchyI;
using nilnul.num.quotient.stream_._cauchy;
using A = nilnul.num._real._cauchy.ApproachI;

namespace nilnul.num._real.cauchy.op_.unary_._scale
{


	public class Ret :
		nilnul.num._real.cauchy._call.Arg
		,
		C
	{
		private Q0 _scale;

		public Q0 scale
		{
			get { return _scale; }
			set { _scale = value; }
		}


		public Ret( Q0 scale, C arg ) : base(arg)
		{
			_scale = scale;
		}
		public A approach =>  nilnul.num._real._cauchy.approach.op_.unary_._ScaleX.Scale( arg.approach, _scale);

		public Q0 next()
		{
			return _scale * arg.next();
			//throw new NotImplementedException();
		}
		//todo
		//throw new NotImplementedException();
	
	}
}
