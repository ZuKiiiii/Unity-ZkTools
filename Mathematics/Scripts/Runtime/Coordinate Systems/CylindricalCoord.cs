﻿using System;
using UnityEngine;
using ZkTools.Mathematics.Angles;
using ZkTools.Mathematics.Swizzling;

namespace ZkTools.Mathematics.CoordinateSystems
{
	[System.Serializable]
	public struct CylindricalCoord : IEquatable<CylindricalCoord>, IFormattable
	{
		#region // ==============================[Static Variables]============================== //

			public static readonly CylindricalCoord Backward = Vector3.back.ToCylindrical();

			public static readonly CylindricalCoord Down = Vector3.down.ToCylindrical();

			public static readonly CylindricalCoord Forward = Vector3.forward.ToCylindrical();

			public static readonly CylindricalCoord Left = Vector3.left.ToCylindrical();

			public static readonly CylindricalCoord One = Vector3.one.ToCylindrical();

			public static readonly CylindricalCoord Right = Vector3.right.ToCylindrical();

			public static readonly CylindricalCoord Up = Vector3.up.ToCylindrical();

			public static readonly CylindricalCoord Zero = new CylindricalCoord(0.0f, 0.0f, 0.0f);

		#endregion

		#region // ==============================[Editable Variables]============================== //

			/** The axial distance or radial distance ρ is the Euclidean distance from the z-axis to the point P. **/
			public float rho;

			/** The azimuth is the angle between the reference direction on the chosen plane and the line from the origin to the projection of P on the plane. **/
			public Radian theta;

			/** The axial coordinate or height z is the signed distance from the chosen plane to the point P. **/
			public float z;

		#endregion

		#region // ==============================[Properties]============================== //

			public SphericalCoord Spherical => CoordinateSystem.CylindricalToSpherical(this);

			public Vector2 Vector2 => CoordinateSystem.CylindricalToCartesian(this);

			public Vector3 Vector3 => CoordinateSystem.CylindricalToCartesian(this);

		#endregion

		#region // ==============================[Constructor + Destructor]============================== //

			public CylindricalCoord (float p_rho, Radian p_theta, float p_z)
			{
				rho = p_rho;
				theta = p_theta;
				z = p_z;
			}

			public CylindricalCoord (CylindricalCoord p_copy)
			{
				rho = p_copy.rho;
				theta = p_copy.theta;
				z = p_copy.z;
			}

			public CylindricalCoord (SphericalCoord p_sphericalCoord)
			{
				CoordinateSystem.SphericalToCylindrical(p_sphericalCoord, out rho, out theta, out z);
			}

			public CylindricalCoord (Vector2 p_vector2, float p_z)
			{
				CoordinateSystem.CartesianToCylindrical(p_vector2.GetXYK(p_z), out rho, out theta, out z);
			}

			public CylindricalCoord (Vector3 p_vector3)
			{
				CoordinateSystem.CartesianToCylindrical(p_vector3, out rho, out theta, out z);
			}

		#endregion

		#region // ==============================[Inherited Methods]============================== //

			public bool Equals (CylindricalCoord p_other)
			{
				return rho.Equals(p_other.rho) && theta.Equals(p_other.theta) && z.Equals(p_other.z);
			}

			public override bool Equals (object p_obj)
			{
				return p_obj is CylindricalCoord other && Equals(other);
			}

			public override int GetHashCode ()
			{
				unchecked
				{
					var hashCode = rho.GetHashCode();
					hashCode = (hashCode * 397) ^ theta.GetHashCode();
					hashCode = (hashCode * 397) ^ z.GetHashCode();
					return hashCode;
				}
			}

			public override string ToString ()
			{
				return "CylindiralCoord (" + rho + "," + theta + "," + z + ")";
			}

			public string ToString (string p_format)
			{
				return "CylindiralCoord (" + rho.ToString(p_format) + "," + theta.ToString(p_format) + "," + z.ToString(p_format) + ")";
			}

			public string ToString (string p_format, IFormatProvider p_formatProvider)
			{
				return "CylindiralCoord (" + rho.ToString(p_format, p_formatProvider) + "," + theta.ToString(p_format, p_formatProvider) + "," + z.ToString(p_format, p_formatProvider) + ")";
			}

		#endregion

		#region // ==============================[Operators]============================== //

			public static bool operator== (CylindricalCoord p_lhs, CylindricalCoord p_rhs)
			{
				return p_lhs.rho == p_rhs.rho && p_lhs.theta == p_rhs.theta && p_lhs.z == p_rhs.z;
			}

			public static bool operator!= (CylindricalCoord p_lhs, CylindricalCoord p_rhs)
			{
				return !(p_lhs == p_rhs);
			}

			public static implicit operator CylindricalCoord (Vector2 p_vector2)
			{
				return p_vector2.ToCylindrical();
			}

			public static implicit operator CylindricalCoord (Vector3 p_vector3)
			{
				return p_vector3.ToCylindrical();
			}

			public static implicit operator SphericalCoord (CylindricalCoord p_this)
			{
				return p_this.Spherical;
			}

			public static implicit operator Vector2 (CylindricalCoord p_this)
			{
				return p_this.Vector3;
			}

			public static implicit operator Vector3 (CylindricalCoord p_this)
			{
				return p_this.Vector3;
			}

		#endregion
	}
}