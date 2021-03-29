using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics.Extensions
{
	public static partial class Vector3X 
	{
		#region // ==============================[Static Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Ceil (Vector3 p_vector)
			{
				return new Vector3(MathF.Ceil(p_vector.x), MathF.Ceil(p_vector.y), MathF.Ceil(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3Int CeilToInt (Vector3 p_vector)
			{
				return new Vector3Int(MathF.CeilToInt(p_vector.x), MathF.CeilToInt(p_vector.y), MathF.CeilToInt(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Center (Vector3 p_lhs, Vector3 p_rhs)
			{
				return (p_lhs + p_rhs) * 0.5f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 CenterDirection (Vector3 p_lhs, Vector3 p_rhs)
			{
				return (p_lhs + p_rhs).normalized;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Clamp (Vector3 p_vector, Vector3 p_min, Vector3 p_max)
			{
				return new Vector3(MathF.Clamp(p_vector.x, p_min.x, p_max.x), MathF.Clamp(p_vector.y, p_min.y, p_max.y), MathF.Clamp(p_vector.z, p_min.z, p_max.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Clamp (Vector3 p_vector, float p_min, Vector3 p_max)
			{
				return new Vector3(MathF.Clamp(p_vector.x, p_min, p_max.x), MathF.Clamp(p_vector.y, p_min, p_max.y), MathF.Clamp(p_vector.z, p_min, p_max.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Clamp (Vector3 p_vector, Vector3 p_min, float p_max)
			{
				return new Vector3(MathF.Clamp(p_vector.x, p_min.x, p_max), MathF.Clamp(p_vector.y, p_min.y, p_max), MathF.Clamp(p_vector.z, p_min.z, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Clamp (Vector3 p_vector, float p_min, float p_max)
			{
				return new Vector3(MathF.Clamp(p_vector.x, p_min, p_max), MathF.Clamp(p_vector.y, p_min, p_max), MathF.Clamp(p_vector.z, p_min, p_max));
			}

			public static Vector3 ClampMagnitude (Vector3 p_vector, float p_minMagnitude, float p_maxMagnitude)
			{
				float thisMagnitude = p_vector.magnitude;
				if (thisMagnitude.IsNearlyZero())
					return Vector3.zero;

				return MathF.Clamp(thisMagnitude, p_minMagnitude, p_maxMagnitude) * p_vector / thisMagnitude;
			}

			public static Vector3 ClampMaxMagnitude (Vector3 p_vector, float p_maxMagnitude)
			{
				p_maxMagnitude = MathF.Max(p_maxMagnitude, 0.0f);
				float magnitudeSquared = p_vector.sqrMagnitude;

				return magnitudeSquared > MathF.Square(p_maxMagnitude) ? p_vector * (MathF.InvSqrt(magnitudeSquared) * p_maxMagnitude) : p_vector;
			}

			public static Vector3 ClampMinMagnitude (this Vector3 p_this, float p_minMagnitude)
			{
				p_minMagnitude = MathF.Max(p_minMagnitude, 0.0f);
				float magnitudeSquared = p_this.sqrMagnitude;

				return magnitudeSquared < MathF.Square(p_minMagnitude) ? p_this * (MathF.InvSqrt(magnitudeSquared) * p_minMagnitude) : p_this;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Cross (Vector3 p_lhs, Vector3 p_rhs)
			{
				return new Vector3 (p_lhs.y * p_rhs.z - p_lhs.z * p_rhs.y, p_lhs.z * p_rhs.x - p_lhs.x * p_rhs.z, p_lhs.x * p_rhs.y - p_lhs.y * p_rhs.x);
			}

			// [MethodImpl(MethodImplOptions.AggressiveInlining)]
			// public static float Cross (float p_lhs, Vector3 p_rhs)
			// {
			// }

			// [MethodImpl(MethodImplOptions.AggressiveInlining)]
			// public static float Cross (Vector3 p_lhs, float p_rhs)
			// {
			// }

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Direction (Vector3 p_from, Vector3 p_to)
			{
				return FromTo(p_from, p_to).normalized;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance (Vector3 p_lhs, Vector3 p_rhs)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DistanceSqr (Vector3 p_lhs, Vector3 p_rhs)
			{
				return p_lhs.x * p_rhs.x + p_lhs.y * p_rhs.y + p_lhs.z * p_rhs.z;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Dot (Vector3 p_lhs, Vector3 p_rhs)
			{
				return p_lhs.x * p_rhs.x + p_lhs.y * p_rhs.y + + p_lhs.z * p_rhs.z;
			}

			public static void Exec (ref Vector3 p_vector, Func<float, float> p_xAction, Func<float, float> p_yAction, Func<float, float> p_zAction)
			{
				p_vector.x = p_xAction?.Invoke(p_vector.x) ?? p_vector.x;
				p_vector.y = p_yAction?.Invoke(p_vector.y) ?? p_vector.y;
				p_vector.z = p_yAction?.Invoke(p_vector.z) ?? p_vector.z;
			}

			// p_direction must be normalized !!!;
			public static Vector3 ExtractDotVector (Vector3 p_vector, Vector3 p_direction)
			{
				float amount = Vector3.Dot(p_vector, p_direction);
				return p_direction * amount;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Floor (Vector3 p_vector)
			{
				return new Vector3(MathF.Floor(p_vector.x), MathF.Floor(p_vector.y));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3Int FloorToInt (Vector3 p_vector)
			{
				return new Vector3Int(MathF.FloorToInt(p_vector.x), MathF.FloorToInt(p_vector.y), MathF.FloorToInt(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 FromTo (Vector3 p_from, Vector3 p_to)
			{
				return p_to - p_from;
			}

			public static Vector3 GetAbs (this Vector3 p_this)
			{
				return new Vector3(MathF.Abs(p_this.x), MathF.Abs(p_this.y), MathF.Abs(p_this.z));
			}

			public static float GetAbsMax (this Vector3 p_this)
			{
				return MathF.Max(MathF.Abs(p_this.x), MathF.Abs(p_this.y), MathF.Abs(p_this.z));
			}

			public static float GetAbsMin(this Vector3 p_this)
			{
				return MathF.Min(MathF.Abs(p_this.x), MathF.Abs(p_this.y), MathF.Abs(p_this.z));
			}

			public static float GetMax (this Vector3 p_this)
			{
				return MathF.Max(p_this.x, p_this.y, p_this.z);
			}

			public static float GetMin (this Vector3 p_this)
			{
				return MathF.Max(p_this.x, p_this.y, p_this.z);
			}

			public static bool IsCollinear (Vector3 p_lhs, Vector3 p_rhs)
			{
				return Cross(p_lhs, p_rhs).IsZero();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InverseLerp (Vector3 p_a, Vector3 p_b, Vector3 p_value)
			{
				return new Vector3(MathF.InverseLerp(p_a.x, p_b.x, p_value.x), MathF.InverseLerp(p_a.y, p_b.y, p_value.y), MathF.InverseLerp(p_a.z, p_b.z, p_value.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 InverseLerpClamped (Vector3 p_a, Vector3 p_b, Vector3 p_value, Vector3 p_min, Vector3 p_max)
			{
				return Clamp(InverseLerp(p_a, p_b, p_value), p_min, p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (this Vector3 p_lhs, Vector3 p_rhs, float p_tolerance = float.Epsilon)
			{
				return IsNearlyEqual(p_lhs, p_rhs, Vector3.one * p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (this Vector3 p_lhs, Vector3 p_rhs, Vector3 p_tolerance)
			{
				return	MathF.IsNearlyEqual(p_lhs.x, p_rhs.x, p_tolerance.x) && MathF.IsNearlyEqual(p_lhs.y, p_rhs.y, p_tolerance.y) && MathF.IsNearlyEqual(p_lhs.z, p_rhs.z, p_tolerance.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (this Vector3 p_this, float p_tolerance = float.Epsilon)
			{
				return p_this.IsNearlyZero(Vector3.one * p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (this Vector3 p_this, Vector3 p_tolerance)
			{
				return	p_this.x.IsNearlyZero(p_tolerance.x) && p_this.y.IsNearlyZero(p_tolerance.y) && p_this.z.IsNearlyZero(p_tolerance.z);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOrthogonal (Vector3 p_lhs, Vector3 p_rhs)
			{
				return Vector3.Dot(p_lhs, p_rhs).IsZero();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsOrthogonal (Vector3 p_lhs, Vector3 p_rhs, float p_tolerance)
			{
				return MathF.IsNearlyZero(Vector3.Dot(p_lhs, p_rhs), p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsZero (this Vector3 p_this)
			{
				return p_this == Vector3.zero;
			}

			public static Vector3 Lerp (Vector3 p_a, Vector3 p_b, float p_t)
			{
				return Lerp(p_a, p_b, new Vector3(p_t, p_t, p_t));
			}

			public static Vector3 Lerp (Vector3 p_a, Vector3 p_b, Vector3 p_t)
			{
				return new Vector3(MathF.Lerp(p_a.x, p_b.x, p_t.x), MathF.Lerp(p_a.y, p_b.y, p_t.y), MathF.Lerp(p_a.z, p_b.z, p_t.z));
			}

			public static Vector3 LerpClamped (Vector3 p_a, Vector3 p_b, float p_t)
			{
				return LerpClamped(p_a, p_b, new Vector3(p_t, p_t, p_t));
			}

			public static Vector3 LerpClamped (Vector3 p_a, Vector3 p_b, Vector3 p_t)
			{
				return new Vector3(MathF.LerpClamped(p_a.x, p_b.x, p_t.x), MathF.LerpClamped(p_a.y, p_b.y, p_t.y), MathF.LerpClamped(p_a.z, p_b.z, p_t.z));
			}
			
			public static Vector3 Max (Vector3 p_lhs, Vector3 p_rhs)
			{
				return new Vector3(MathF.Max(p_lhs.x, p_rhs.x), MathF.Max(p_lhs.y, p_rhs.y), MathF.Max(p_lhs.z, p_rhs.z));
			}

			public static Vector3 Min (Vector3 p_lhs, Vector3 p_rhs)
			{
				return new Vector3(MathF.Min(p_lhs.x, p_rhs.x), MathF.Min(p_lhs.y, p_rhs.y), MathF.Min(p_lhs.z, p_rhs.z));
			}

			public static Vector3 Remap (Vector3 p_value, Vector3 p_inMin, Vector3 p_inMax, Vector3 p_outMin, Vector3 p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerp(p_inMin, p_inMax, p_value));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 RemapClamped (Vector3 p_value, Vector3 p_inMin, Vector3 p_inMax, Vector3 p_outMin, Vector3 p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerpClamped(p_inMin, p_inMax, p_value, Vector3.zero, Vector3.one));
			}

			public static Vector3 RemoveDotVector (Vector3 p_vector, Vector3 p_direction)
			{
				return p_vector - ExtractDotVector(p_vector, p_direction);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 Round (Vector3 p_vector)
			{
				return new Vector3(MathF.Round(p_vector.x), MathF.Round(p_vector.y), MathF.Round(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3Int RoundToInt (Vector3 p_vector)
			{
				return new Vector3Int(MathF.RoundToInt(p_vector.x), MathF.RoundToInt(p_vector.y), MathF.RoundToInt(p_vector.z));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector3 WithMagnitude (this Vector3 p_this, float p_magnitude)
			{
				return p_this.normalized * p_magnitude;
			}
			
		#endregion
	}
}