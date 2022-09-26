using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.dbl.bound
{
	public class Walk
	{
		private Bound _bound;

		public Bound bound
		{
			get { return _bound; }
			set { _bound = value; }
		}

		private nilnul.num.dbl_.Positive _step;

		public nilnul.num.dbl_.Positive step
		{
			get { return _step; }
			set { _step = value; }
		}

		public Walk(Bound bound, nilnul.num.dbl_.Positive step)
		{
			_bound = bound;
			_step = step;
		}

		public IEnumerable<double> seq {
			get {
				for (double	 i = _bound.lower.mark; i<=_bound.upper.mark ; i+=_step)
				{
					if (_bound.contain(i))
					{
						yield return i;
					}

				}
			}
		}

		static public Walk CreateCloseOvNeighbor(double center, nilnul.num.dbl_.Nonneg radius, nilnul.num.dbl_.Positive step) {
			return new Walk(
				Bound.CreateCloseOvNeighbor(center, radius)
				,
				step
			);
		}



		static public Walk CreateCloseOvNeighbor(double center, nilnul.num.dbl_.Nonneg radius, double step) {
			return CreateCloseOvNeighbor(center, radius,new dbl_.Positive(step));
		}

		static public Walk CreateCloseOvNeighbor(double center, double radius, double step) {
			return CreateCloseOvNeighbor(center, new dbl_.Nonneg( radius),(step));
		}
		/// <summary>
		/// loop steps if odd; steps+1 if even
		/// </summary>
		/// <param name="center"></param>
		/// <param name="step"></param>
		/// <param name="steps"></param>
		/// <returns></returns>
		/// <remarks></remarks>
		static public Walk CreateStepsAroundCenter(double center,  nilnul.num.dbl_.Positive step, uint steps) {
			return CreateCloseOvNeighbor(center, step*steps / 2 , step);
		}

		static public Walk CreateStepsAroundCenter(double center,  double step, uint steps) {
			return CreateStepsAroundCenter(center, new dbl_.Positive(step), steps);
		}
		static public Walk CreateStepsAroundCenter(double center,  double step, int steps) {
			return CreateStepsAroundCenter(center, (step), (uint)steps);
		}


		static public Walk CreateClopenOvNeighbor(double center, nilnul.num.dbl_.Positive radius, nilnul.num.dbl_.Positive step) {
			return new Walk(
				Bound.CreateClopenOvNeighbor(center, radius)
				,
				step
			);
		}

		static public Walk CreateClopenOvNeighbor(double center, nilnul.num.dbl_.Positive radius, double step) {
			return CreateClopenOvNeighbor(center, radius,new dbl_.Positive(step));
		}

		static public Walk CreateClopenOvNeighbor(double center, double radius, double step) {
			return CreateClopenOvNeighbor(center, new dbl_.Positive( radius),(step));
		}

		static public Walk CreateOpenOvNeighbor(double center, nilnul.num.dbl_.Positive radius, nilnul.num.dbl_.Positive step) {
			return new Walk(
				Bound.CreateOpenOvNeighbor(center, radius)
				,
				step
			);
		}

		static public Walk CreateOpenOvNeighbor(double center, nilnul.num.dbl_.Positive radius, double step) {
			return CreateOpenOvNeighbor(center, radius,new dbl_.Positive(step));
		}

		static public Walk CreateOpenOvNeighbor(double center, double radius, double step) {
			return CreateOpenOvNeighbor(center, new dbl_.Positive( radius),(step));
		}


		static public Walk CreateOpenCloseOvNeighbor(double center, nilnul.num.dbl_.Positive radius, nilnul.num.dbl_.Positive step) {
			return new Walk(
				Bound.CreateOpenCloseOvNeighbor(center, radius)
				,
				step
			);
		}

		static public Walk CreateOpenCloseOvNeighbor(double center, nilnul.num.dbl_.Positive radius, double step) {
			return CreateOpenCloseOvNeighbor(center, radius,new dbl_.Positive(step));
		}

		static public Walk CreateOpenCloseOvNeighbor(double center, double radius, double step) {
			return CreateOpenCloseOvNeighbor(center, new dbl_.Positive( radius),(step));
		}

		public override string ToString()
		{
			return $"{_bound}@{_step}";
		}

	}
}
