using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._real
{
	/// <summary>
	/// 
	/// </summary>
	public class Singleton : CofinalI1
	{
		private ApproachI _approach;

		public ApproachI approach
		{
			get { return _approach; }
			set { _approach = value; }
		}

		public Singleton(ApproachI approach)
		{
			_approach = approach;
		}

		

		public ApproachI choice
		{
			get
			{
				return _approach;
				throw new NotImplementedException();
			}
		}
	}
}
