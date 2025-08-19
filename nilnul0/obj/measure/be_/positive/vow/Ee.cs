using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.measure.be_.positive.vow
{
	public class Ee<TUnit,TMeasure> : nilnul.obj.be.en_.BeDefaulted2<TMeasure, Positive4dbl<TUnit,TMeasure>>
		where TUnit: _measure.Unit4dblI
		where TMeasure:obj.Measure4dblI<TUnit>
	{
		public Ee(TMeasure val) : base(val)
		{
		}
	}
	public class Ee<TUnit> : nilnul.obj.be.en_.BeDefaulted2<obj.Measure4dblI<TUnit>, Positive4dbl<TUnit>>
		where TUnit: _measure.Unit4dblI
	{
		public Ee(Measure4dblI<TUnit> val) : base(val)
		{
		}
	}


}
