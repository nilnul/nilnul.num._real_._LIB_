using nilnul.obj.of_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.of_.binary.cascader_
{
	public class Op8default4dbl<TOp>
		:
		of_.binary.Cascader4dbl
		where TOp:
		obj.of_.BinaryI<double>,new()
	{
		public Op8default4dbl() : base(

			 nilnul._obj.typ_._UnisonX<TOp>.Unison
		)
		{
		}

		static public Op8default4dbl<TOp> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Op8default4dbl<TOp>>.Unison;
			}
		}


	}
}
