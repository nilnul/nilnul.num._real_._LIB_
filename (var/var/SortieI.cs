using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.objs.be_.distinct.vow;

namespace nilnul.num.real.var
{
	public interface SortieI:nilnul.obj.var._sortie_.BlankI
	{

	}

	public class Sortie
		:

		nilnul.obj.sortie_.EqDefault<nilnul.num.real.VarI, nilnul.num.real.var.Eq1, Str>
		,
		SortieI

	{
		public Sortie(Str val) : base(val)
		{
		}
	}

}
