using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/// <summary>
	/// finite ordered repeatable exprs.
	/// </summary>
	public interface ExprsI
		:
		IEnumerable< nilnul.num.real.ExprI>
	{
	}

	public class Exprs
		:
		nilnul.obj.Box1<IEnumerable<nilnul.num.real.ExprI>>
		,
		ExprsI
	{
		public Exprs(IEnumerable<ExprI> val) : base(val)
		{
		}
		public Exprs():this(new ExprI[] { })
		{

		}

		public IEnumerator<ExprI> GetEnumerator()
		{
			return boxed.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
