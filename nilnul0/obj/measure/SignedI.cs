using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.measure
{

	public interface SignedI<T>
		:
		ISigned
		,
		_signed_.QuantityI
		,
		_measure_.UnitI1<T>
		where T: _measure.UnitI
	{

	}
}
