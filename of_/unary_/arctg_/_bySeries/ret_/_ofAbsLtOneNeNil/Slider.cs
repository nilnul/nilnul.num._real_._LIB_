using nilnul.num.quotient.bound_;
using nilnul.num.quotient.stream_.slider;
using nilnul.num.quotient_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.unary_.arctg_._bySeries.ret_._ofAbsLtOneNeNil
{
	

	public class AsReal
		: nilnul.obj.Box<_ofAbsLeOne.Series>
		, RealI
	{
		public AsReal(num.Quotient1 val) : base(new _ofAbsLeOne. Series(val))
		{
			_current = Closed.Create_orderIfNecessary(0, val);
		}
		private Closed _current;
		public Closed current => _current;

		private BigInteger _index = 0;
		public void squeeze(Positive1 diameter)
		{
			// let d= diameter
			//  1/(2n+1) * |x| ^ (2n+1)        <=     d
			//  <==     1/(2k+1) * |x| ^ (2n+1) <=d
			// <==
			//			|x| ^ (2n+1)  <=  d * 1/(2k+1)
			// <==   (2n+1) >=  log(|x|, d / (2k+1) ) , note here |x| <1

			var n =	(nilnul.num.quotient.co_.startPositiveLtOne._LogX.Bound(
				this.boxed.val.Abs()
				,
				diameter.en * (2 * _index + 1)
			).upper.mark - 1) / 2 + 1;
			if (n <= _index)
			{
				return;
			}

			nilnul.obj.stream._SkipX.Skip(this.boxed, n - _index);

			_index = n;

			_current = num.quotient.bound_.closed.co_.joint._IntersectX.Intersect(
				_current
				,
				Closed.Create_orderIfNecessary(boxed.current,
boxed.current + boxed.nextAugend)
			);




		}
	}


}
