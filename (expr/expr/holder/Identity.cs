using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr.holder
{
	/// <summary>
	/// a law by substitute var with holder such as to accomodate expr, not only number.
	/// Identities are sometimes indicated by the triple bar symbol ≡ instead of =, the equals sign.
	/// An identity is an equation that is always true, no matter what values are chosen.
	///Examples
	///3a + 2a =  5a
	///x²+x² = 2x²
	///5 x 10 = 10 x 5
	///
	/// whileas equation only holds for the unknown takes specific value and this value is called solution.
	/// 
	/// xpressions, equations, formulae and identities are all slightly different types of algebraic notation. In this video we’re going to discover the differences. An expression is a collection of letters and numbers, with no equals sign. An equation is two expressions that equal each other, and so can be solved. A formula is a special type of equation. It shows the relationship between different variables, like the area of a circle and the radius. A formula needs more than 1 variable - otherwise it is just an equation. An identity is another special type of equation. They are equations that are true no matter what values are chosen. The two sides of an identity are interchangeable, so we can replace one with the other at any time. Strictly speaking, for identities we should use the three bar sign which means “equivalent to”. But it is common to just see the normal equals sign.
	/// An expression can be a single number, a single variable or a combination of both. So an equation is therefore two expressions equal to one another.
	/// </summary>
	public interface IdentityI
	{
	}
}
