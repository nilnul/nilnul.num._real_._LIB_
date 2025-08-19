using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.slider_.peek.subsume_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// for the underlying stream : 0, 1,2,3, we cannot define factorial, as the first term is nil. we can either define a factorial on 1,2,3, or we can define <see cref="cumulus_.Product"/> on 1,2,3, as for <see cref="nilnul.num.real_.eg_._exp"/>
	/// </remarks>
	public class Product
		:
		nilnul.obj.stream_.SliderA<BigInteger>
		,
nilnul.obj.stream_.SliderI<BigInteger>
		
	{
		private nilnul.obj.stream_.slider_.PeekI<BigInteger>	_terms;

		public nilnul.obj.stream_.slider_.PeekI<BigInteger> terms
		{
			get { return _terms; }
			set { _terms = value; }
		}
		public Product(nilnul.obj.stream_.slider_.PeekI<BigInteger> slider)
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
