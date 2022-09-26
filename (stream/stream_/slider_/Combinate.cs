using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream_.slider_
{
	public class Combinate
		:
		//nilnul.num.real.stream_.slider.op_.binary_._multi.subsumed_.Prod
		//,
		nilnul.num.real.stream_.SliderA
	{

		private slider_.Permutate _permutate;

		public slider_.Permutate permutate
		{
			get { return _permutate; }
			set { _permutate = value; }
		}

		private nilnul.num.stream_.slider_.Factorial _factorial;

		public nilnul.num.stream_.slider_.Factorial factorial
		{
			get { return _factorial; }
			set { _factorial = value; }
		}


		public override RealI current => nilnul.num.real.op_.unary_._ScaleX.Op( _factorial.current, _permutate.current) ;

		public Combinate(num.RealI val) 
		{
			_permutate = new nilnul.num.real.stream_.slider_.Permutate(val);
			_factorial = new num.stream_.slider_.Factorial();
		}

		public override void moveNext()
		{
			_permutate.moveNext();
			_factorial.moveNext();
		}
	}
}
