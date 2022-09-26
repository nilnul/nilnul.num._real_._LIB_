using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real
{
	/// <summary>
	/// a quadruple of float.
	/// </summary>
	public class TrioF
	{
		private float _x;

		public float x
		{
			get { return _x; }
			set { _x = value; }
		}
		private float _y;

		public float y
		{
			get { return _y; }
			set { _y = value; }
		}

		private float _z;

		public float z
		{
			get { return _z; }
			set { _z = value; }
		}

		public TrioF(float x, float y, float z)
		{
			_x = x;
			_y = y;
			_z = z;
		}

		static public implicit operator float[](TrioF trio) {
			return new float[] { trio._x, trio._y, trio._z };
		}
		

	}
}
