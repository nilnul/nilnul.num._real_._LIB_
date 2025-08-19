using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.slider.cumulus_
{
	public class Product
		:
		nilnul.obj.stream_.SliderA<BigInteger>
		,
nilnul.obj.stream_.SliderI<BigInteger>
		,
		nilnul.obj.stream_.slider._cumulus_.NextCumulee<BigInteger>
		
	{


		protected nilnul.obj.stream_.SliderI<BigInteger>	_terms;

		protected nilnul.obj.stream_.SliderI<BigInteger> terms
		{
			get { return _terms; }
			//set { _terms = value; }
		}

		public BigInteger toBeCumulated =>  _terms.current;

		public Product(nilnul.obj.stream_.SliderI<BigInteger> slider)
		{
			this._terms = slider;
			_current = 1;
		}


		private BigInteger _current;

		public override BigInteger current => _current;


		public override void moveNext()
		{
			_current *= _terms.current;
			_terms.moveNext();
		}
	}
}
