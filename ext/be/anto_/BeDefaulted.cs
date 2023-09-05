using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.be.anto_
{
	public class BeDefaulted<T>
		: Anto4dbl
		where T : ext.Be4dblI, new()
	{
		public BeDefaulted() : base(

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<T>.Instance

		)
		{
		}

		static public BeDefaulted<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefaulted<T>>.Instance;
			}
		}

	}
}
