using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.double_.ext
{
	public class Ord
		:nilnul.num.integer._ext._generic.Comparer_TEqDefault<double,_ext.ExtI>
	{

		static public Ord Singleton = SingletonByDefaultNew<Ord>.Instance;


		static public bool Gt(_ext.ExtI x, _ext.ExtI y) {
			return Singleton.Compare(x, y) > 0;
		}

		static public bool Lt(_ext.ExtI x, _ext.ExtI y) {
			return Singleton.Compare(x, y)< 0;
		}
		static public bool Eq(_ext.ExtI x, _ext.ExtI y) {
			return Singleton.Compare(x, y)== 0;
		}

	}
}
