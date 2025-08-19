using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.measure
{
	

	public interface Signed4dblI<T>
		:
		ISigned
		,
		_signed_.Quantity4dblI
		,
		_measure_.Unit4dblI<T>
		where T: _measure.Unit4dblI
	{

	}
	
}
