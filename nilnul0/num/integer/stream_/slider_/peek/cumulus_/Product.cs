using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.slider_.peek.cumulus_
{
	public class Product
		:
		nilnul.obj.stream_.SliderA<BigInteger>
		,
nilnul.obj.stream_.SliderI<BigInteger>
		
	{


		protected nilnul.obj.stream_.slider_.PeekI<BigInteger>	_terms;

		protected nilnul.obj.stream_.slider_.PeekI<BigInteger> terms
		{
			get { return _terms; }
			//set { _terms = value; }
		}

		public BigInteger termAhead => _terms.current;
		public BigInteger termOverhead => _terms.ahead;

		public Product(nilnul.obj.stream_.slider_.PeekI<BigInteger> slider)
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
