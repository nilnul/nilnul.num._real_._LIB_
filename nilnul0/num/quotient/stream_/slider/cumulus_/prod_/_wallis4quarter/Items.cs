using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream_.slider.prod_._wallis4quarter
{
	/// <summary>
	/// 2/1, 2/3
	/// ,
	/// 4/3, 4/5
	/// ,
	/// 6/5, 6/7
	/// </summary>
	public class Items
		:
		nilnul.num.quotient_.denomNonnil.stream_.SliderA
	{

		private nilnul.num.stream_.slider_.even.Dehead _even = new num.stream_.slider_.even.Dehead();

		private nilnul.num.stream_.slider_.Odd1 _odd = new num.stream_.slider_.Odd1();

		private nilnul.bit.stream_.slider_.alt_.NilOne _bit = new bit.stream_.slider_.alt_.NilOne();


		public override DenomNonnil current => new DenomNonnil(_even.current, _odd.current);

		public override void moveNext()
		{
			_bit.moveNext();
			if (_bit.current)
			{
				_odd.moveNext();

			}
			else
			{
				_even.moveNext();
			}
		}
	}
}
