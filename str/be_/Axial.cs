using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.str.be_
{
	public class Axial
		:
		num.real.str.Be4dblI
	{
		public bool be(IEnumerable<double> obj)
		{

			var beginOne = obj.SkipWhile(x => x == 0);

			if (beginOne.Any())
			{
				
				return beginOne.Skip(1).All(a => a == 0);
				
			}
			return true;
		}
		static public Axial Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Axial>.Instance;
			}
		}
	}
}