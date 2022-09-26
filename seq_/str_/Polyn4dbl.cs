using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.seq_.str_
{
	public class Polyn4dbl :
		nilnul.obj.Box1<double>
		,
		num.real.seq_.Str4dblI
		,
		_seq.scroll_.INewly

	{
		private nilnul.NumI1 _indexCeilingInclusive;

		public nilnul.NumI1 indexCeilingInclusive
		{
			get { return _indexCeilingInclusive; }
			set { _indexCeilingInclusive = value; }
		}

		public Polyn4dbl(double x, nilnul.NumI1 indexCeilingInclusive0):base(x)
		{
			_indexCeilingInclusive = indexCeilingInclusive0;
		}

		public Polyn4dbl(double x, nilnul.Num1 indexCeilingInclusive0):this(x, (nilnul.NumI1)(indexCeilingInclusive0) )
		{

		}

		public Polyn4dbl(double x, BigInteger indexCeilingInclusive0):this(x, new nilnul.Num1(indexCeilingInclusive0) )
		{

		}

		/// <summary>
		/// generate new ones.
		/// </summary>
		/// <returns></returns>
		public IEnumerator<double> GetEnumerator()
		{
			double r = 1;
			yield return r; //when index is 0

			for (BigInteger i = 0; i < _indexCeilingInclusive.toBigint().en; i++)
			{
				r *= this.boxed;
				yield return r;
			}

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}
}
