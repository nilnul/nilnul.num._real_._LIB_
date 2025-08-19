using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.slider.subsume_
{
	public class Product
		:
		nilnul.obj.stream_.SliderA<BigInteger>
		,
nilnul.obj.stream_.SliderI<BigInteger>
		
	{
		private nilnul.obj.stream_.SliderI<BigInteger>	_terms;

		public nilnul.obj.stream_.SliderI<BigInteger> terms
		{
			get { return _terms; }
			set { _terms = value; }
		}
		public Product(nilnul.obj.stream_.SliderI<BigInteger> slider)
		{
			this._terms = slider;
			_current = slider.current;
		}

		private BigInteger _current;

		public override BigInteger current => _current;

		public override void moveNext()
		{
			_terms.moveNext();
			_current *= _terms.current;
		}
	}
}
