using nilnul.num.real._bound;
using nilnul.num.real._bound.lowerUpper.be_.dwelt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed_
{
	/// <summary>
	/// a base and a step; the step may be around zero so hard to find the orientation.
	/// this is in fact a grad in nilnul.geometry.linear; it can be an arrow, or a point.
	/// </summary>
	public class Based
		:nilnul.num.real.BoundI
		,
		_bound_.BordersI
	{

		private Real _basis;

		public Real basis
		{
			get { return _basis; }
			set { _basis = value; }
		}

		private Real _displace;

		public Real displace
		{
			get { return _displace; }
			set { _displace = value; }
		}

		public Based(
			Real basis, Real displace 
		)
		{
			_basis = basis;
			_displace = displace;
		}

		public Based(
			RealI basis, RealI displace 
		):this( nilnul.num.Real.Ov(basis) , Real.Ov(displace) )
		{
			
		}

		static public implicit operator Bound1(Based x) {
			return new Bound1(
				x.borders
			);
		}

		public Lower lower => borders.ee.lower;

		public Upper upper => borders.ee.upper;

		public En borders
		{
			get
			{
				if (
					_displace <=0
				)
				{
					return new En(
						new LowerUpper(
							 Lower.CreateClose( _basis+_displace)
							 ,
							 Upper.CreateClose(_basis )
						)
					);

				}

					return new En(
						new LowerUpper(
							 Lower.CreateClose( _basis)
							 ,
							 Upper.CreateClose(_basis+ _displace )
						)
					);

				//throw new NotImplementedException();
			}
		}
	}
}
