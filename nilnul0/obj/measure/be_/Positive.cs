using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.measure.be_
{
	public class Positive4dbl<T,TMeasure>
		:
		nilnul.obj.BeI1<TMeasure>
		where T : _measure.Unit4dblI
		where TMeasure: obj.Measure4dblI<T>
	{
		public bool be(TMeasure obj)
		{
			return obj.amount.realee.ee > 0;

			//throw new NotImplementedException();
		}


		static public Positive4dbl<T,TMeasure> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Positive4dbl<T,TMeasure>>.Instance;
			}
		}

	}
	public class Positive4dbl<T>
		:
		nilnul.obj.BeI1<obj.Measure4dblI<T>>
		where T : _measure.Unit4dblI
	{
		public bool be(Measure4dblI<T> obj)
		{
			return obj.amount.realee.ee > 0;

			//throw new NotImplementedException();
		}


		static public Positive4dbl<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Positive4dbl<T>>.Instance;
			}
		}

	}

}
