using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics.Extensions
{
	public static class Vector4X
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Abs (Vector4 p_vector)
			{
				return new Vector4(MathF.Abs(p_vector.x), MathF.Abs(p_vector.y), MathF.Abs(p_vector.z), MathF.Abs(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Add (Vector4 p_lhs, Vector4 p_rhs)
			{
				return p_lhs + p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Add (ref Vector4 p_lhs, Vector4 p_rhs)
			{
				p_lhs += p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Add (Vector4 p_lhs, float p_rhs)
			{
				return p_lhs + Replicate(p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Add (ref Vector4 p_lhs, float p_rhs)
			{
				p_lhs += Replicate(p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Add (float p_lhs, Vector4 p_rhs)
			{
				return Replicate(p_lhs) + p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Ceil (Vector4 p_vector)
			{
				return new Vector4(MathF.Ceil(p_vector.x), MathF.Ceil(p_vector.y), MathF.Ceil(p_vector.z), MathF.Ceil(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Center (Vector4 p_lhs, Vector4 p_rhs)
			{
				return (p_lhs + p_rhs) * 0.5f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 CenterDirection (Vector4 p_lhs, Vector4 p_rhs)
			{
				return (p_lhs + p_rhs).normalized;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, Vector4 p_min, Vector4 p_max)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min.x, p_max.x), MathF.Clamp(p_vector.y, p_min.y, p_max.y), MathF.Clamp(p_vector.z, p_min.z, p_max.z), MathF.Clamp(p_vector.w, p_min.w, p_max.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, float p_min, Vector4 p_max)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min, p_max.x), MathF.Clamp(p_vector.y, p_min, p_max.y), MathF.Clamp(p_vector.z, p_min, p_max.z), MathF.Clamp(p_vector.w, p_min, p_max.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, Vector4 p_min, float p_max)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min.x, p_max), MathF.Clamp(p_vector.y, p_min.y, p_max), MathF.Clamp(p_vector.z, p_min.z, p_max), MathF.Clamp(p_vector.w, p_min.w, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Clamp (Vector4 p_vector, float p_min = 0.0f, float p_max = 1.0f)
			{
				return new Vector4(MathF.Clamp(p_vector.x, p_min, p_max), MathF.Clamp(p_vector.y, p_min, p_max), MathF.Clamp(p_vector.z, p_min, p_max), MathF.Clamp(p_vector.w, p_min, p_max));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 ClampMagnitude (Vector4 p_vector, float p_minMagnitude, float p_maxMagnitude)
			{
				float thisMagnitude = p_vector.magnitude;
				return thisMagnitude < p_minMagnitude ? (p_vector / thisMagnitude) * p_minMagnitude :
					thisMagnitude > p_maxMagnitude ? (p_vector / thisMagnitude) * p_maxMagnitude : p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 ClampMaxMagnitude (Vector4 p_vector, float p_maxMagnitude)
			{
				float magnitudeSquared = p_vector.magnitude;
				return magnitudeSquared > MathF.Square(p_maxMagnitude) ? p_vector * (MathF.InvSqrt(magnitudeSquared) * p_maxMagnitude) : p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 ClampMinMagnitude (Vector4 p_vector, float p_minMagnitude)
			{
				float magnitudeSquared = p_vector.sqrMagnitude;
				return magnitudeSquared < MathF.Square(p_minMagnitude) ? p_vector * (MathF.InvSqrt(magnitudeSquared) * p_minMagnitude) : p_vector;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance (Vector4 p_lhs, Vector4 p_rhs)
			{
				return MathF.Sqrt(DistanceSqr(p_lhs, p_rhs));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DistanceSqr (Vector4 p_lhs, Vector4 p_rhs)
			{
				return MathF.Square(p_rhs.x - p_lhs.x) + MathF.Square(p_rhs.y - p_lhs.y) + MathF.Square(p_rhs.z - p_lhs.z) + MathF.Square(p_rhs.w - p_lhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Direction (Vector4 p_from, Vector4 p_to)
			{
				return FromTo(p_from, p_to).normalized;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DirectionTo (this Vector4 p_this, Vector4 p_to)
			{
				return Direction(p_this, p_to);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Div (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4(p_lhs.x / p_rhs.x, p_lhs.y / p_rhs.y, p_lhs.z / p_rhs.z, p_lhs.w / p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Div (ref Vector4 p_lhs, Vector4 p_rhs)
			{
				p_lhs = Div(p_lhs, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Div (Vector4 p_lhs, float p_rhs)
			{
				return p_lhs / p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Div (ref Vector4 p_lhs, float p_rhs)
			{
				p_lhs /= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (Vector4 p_dividend, float p_divisor, float p_defaultValue = 0.0f)
			{
				return DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (ref Vector4 p_dividend, float p_divisor, float p_defaultValue = 0.0f)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (Vector4 p_dividend, float p_divisor, Vector4 p_defaultValue)
			{
				return p_divisor.IsZero() ? p_defaultValue : p_dividend / p_divisor;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (ref Vector4 p_dividend, float p_divisor, Vector4 p_defaultValue)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, p_defaultValue);
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (Vector4 p_dividend, Vector4 p_divisor, float p_defaultValue = 0.0f)
			{
				return DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (ref Vector4 p_dividend, Vector4 p_divisor, float p_defaultValue = 0.0f)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, Replicate(p_defaultValue));
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (Vector4 p_dividend, Vector4 p_divisor, Vector4 p_defaultValue)
			{
				return new Vector4
				(
					MathF.DivSafe(p_dividend.x, p_divisor.x, p_defaultValue.x),
					MathF.DivSafe(p_dividend.y, p_divisor.y, p_defaultValue.y),
					MathF.DivSafe(p_dividend.z, p_divisor.z, p_defaultValue.z),
					MathF.DivSafe(p_dividend.w, p_divisor.w, p_defaultValue.w)
				);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 DivSafe (ref Vector4 p_dividend, Vector4 p_divisor, Vector4 p_defaultValue)
			{
				p_dividend = DivSafe(p_dividend, p_divisor, p_defaultValue);
				return p_dividend;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Dot (Vector4 p_lhs, Vector4 p_rhs)
			{
				return p_lhs.x * p_rhs.x + p_lhs.y * p_rhs.y + p_lhs.z * p_rhs.z + p_lhs.w * p_rhs.w;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Floor (Vector4 p_vector)
			{
				return new Vector4(MathF.Floor(p_vector.x), MathF.Floor(p_vector.y), MathF.Floor(p_vector.z), MathF.Floor(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Frac (Vector4 p_value)
			{
				return p_value - Floor(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 FromTo (Vector4 p_from, Vector4 p_to)
			{
				return p_to - p_from;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMax (this Vector3 p_this)
			{
				return Max(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GetMin (this Vector3 p_this)
			{
				return Min(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 InverseLerp (Vector4 p_a, Vector4 p_b, Vector4 p_value)
			{
				return Div(p_value - p_a, p_b - p_a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 InverseLerpClamped (Vector4 p_a, Vector4 p_b, Vector4 p_value, Vector4 p_min, Vector4 p_max)
			{
				return Clamp(InverseLerp(p_a, p_b, p_value), p_min, p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Lerp (Vector4 p_a, Vector4 p_b, float p_t)
			{
				return p_a + (p_b - p_a) * p_t;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Lerp (Vector4 p_a, Vector4 p_b, Vector4 p_t)
			{
				return new Vector4(MathF.Lerp(p_a.x, p_b.x, p_t.x), MathF.Lerp(p_a.y, p_b.y, p_t.y), MathF.Lerp(p_a.z, p_b.z, p_t.z), MathF.Lerp(p_a.w, p_b.w, p_t.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 LerpClamped (Vector4 p_a, Vector4 p_b, float p_t)
			{
				return LerpClamped(p_a, p_b, new Vector4(p_t, p_t, p_t, p_t));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 LerpClamped (Vector4 p_a, Vector4 p_b, Vector4 p_t)
			{
				return new Vector4(MathF.LerpClamped(p_a.x, p_b.x, p_t.x), MathF.LerpClamped(p_a.y, p_b.y, p_t.y), MathF.LerpClamped(p_a.z, p_b.z, p_t.z), MathF.LerpClamped(p_a.w, p_b.w, p_t.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void GetDirectionAndMagnitude (this Vector4 p_this, out Vector4 p_direction, out float p_magnitude)
			{
				p_magnitude = p_this.magnitude;
				p_direction = p_this / p_magnitude;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static (Vector4 p_direction, float p_magnitude) GetDirectionAndMagnitude (this Vector4 p_this)
			{
				float magnitude = p_this.magnitude;
				Vector4 direction = p_this / magnitude;
				return (direction, magnitude);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void GetDirectionAndMagnitudeSafe (this Vector4 p_this, out Vector4 p_direction, out float p_magnitude, float p_defaultValue = 0.0f)
			{
				p_magnitude = p_this.magnitude;
				p_direction = DivSafe(p_this, p_magnitude, p_defaultValue);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void GetDirectionAndMagnitudeSafe (this Vector4 p_this, out Vector4 p_direction, out float p_magnitude, Vector4 p_defaultValue)
			{
				p_magnitude = p_this.magnitude;
				p_direction = DivSafe(p_this, p_magnitude, p_defaultValue);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static (Vector4 p_direction, float p_magnitude) GetDirectionAndMagnitudeSafe (this Vector4 p_this, float p_defaultValue = 0.0f)
			{
				float magnitude = p_this.magnitude;
				Vector4 direction = DivSafe(p_this, magnitude, p_defaultValue);
				return (direction, magnitude);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static (Vector4 p_direction, float p_magnitude) GetDirectionAndMagnitudeSafe (this Vector4 p_this, Vector4 p_defaultValue)
			{
				float magnitude = p_this.magnitude;
				Vector4 direction = DivSafe(p_this, magnitude, p_defaultValue);
				return (direction, magnitude);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsZero (this Vector4 p_this)
			{
				return p_this == Vector4.zero;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (Vector4 p_vector)
			{
				return MathF.Max(p_vector.x, p_vector.y, p_vector.z, p_vector.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4(MathF.Max(p_lhs.x, p_rhs.x), MathF.Max(p_lhs.y, p_rhs.y), MathF.Max(p_lhs.z, p_rhs.z), MathF.Max(p_lhs.w, p_rhs.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (Vector4 p_a, Vector4 p_b, Vector4 p_c)
			{
				return Max(Max(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (Vector4 p_a, Vector4 p_b, Vector4 p_c, Vector4 p_d)
			{
				return Max(Max(Max(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Max (params Vector4[] p_values)
			{
				return p_values.Max();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (Vector4 p_vector)
			{
				return MathF.Min(p_vector.x, p_vector.y, p_vector.z, p_vector.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4(MathF.Min(p_lhs.x, p_rhs.x), MathF.Min(p_lhs.y, p_rhs.y), MathF.Min(p_lhs.z, p_rhs.z), MathF.Min(p_lhs.w, p_rhs.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (Vector4 p_a, Vector4 p_b, Vector4 p_c)
			{
				return Min(Min(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (Vector4 p_a, Vector4 p_b, Vector4 p_c, Vector4 p_d)
			{
				return Min(Min(Min(p_a, p_b), p_c), p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Min (params Vector4[] p_values)
			{
				return p_values.Min();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Mul (Vector4 p_lhs, Vector4 p_rhs)
			{
				return new Vector4(p_lhs.x * p_rhs.x, p_lhs.y * p_rhs.y, p_lhs.z * p_rhs.z, p_lhs.w * p_rhs.w);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Mul (ref Vector4 p_lhs, Vector4 p_rhs)
			{
				p_lhs = Mul(p_lhs, p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Mul (Vector4 p_lhs, float p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Mul (ref Vector4 p_lhs, float p_rhs)
			{
				p_lhs *= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Mul (float p_lhs, Vector4 p_rhs)
			{
				return p_lhs * p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Normalized (this Vector4 p_vector)
			{
				return p_vector / p_vector.magnitude;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 NormalizedSafe(this Vector4 p_vector, float p_defaultValue = 0.0f)
			{
				return NormalizedSafe(p_vector, Replicate(p_defaultValue));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 NormalizedSafe(this Vector4 p_vector, Vector4 p_defaultValue)
			{
				return p_vector.IsZero() ? p_defaultValue : Normalized(p_vector);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Replicate (float p_value)
			{
				return new Vector4(p_value, p_value, p_value, p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Round (Vector4 p_vector)
			{
				return new Vector4(MathF.Round(p_vector.x), MathF.Round(p_vector.y), MathF.Round(p_vector.z), MathF.Round(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sign (Vector4 p_value)
			{
				return new Vector4(MathF.Sign(p_value.x), MathF.Sign(p_value.y), MathF.Sign(p_value.z), MathF.Sign(p_value.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sign (Vector4 p_value, float p_tolerance)
			{
				return new Vector4(MathF.Sign(p_value.x, p_tolerance), MathF.Sign(p_value.y, p_tolerance), MathF.Sign(p_value.z, p_tolerance), MathF.Sign(p_value.w, p_tolerance));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sign (Vector4 p_value, Vector4 p_tolerance)
			{
				return new Vector4(MathF.Sign(p_value.x, p_tolerance.x), MathF.Sign(p_value.y, p_tolerance.y), MathF.Sign(p_value.z, p_tolerance.z), MathF.Sign(p_value.w, p_tolerance.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 SignPos (Vector4 p_value)
			{
				return new Vector4(MathF.SignPos(p_value.x), MathF.SignPos(p_value.y), MathF.SignPos(p_value.z), MathF.SignPos(p_value.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sqrt (Vector4 p_vector)
			{
				return new Vector4(MathF.Sqrt(p_vector.x), MathF.Sqrt(p_vector.y), MathF.Sqrt(p_vector.z), MathF.Sqrt(p_vector.w));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sub (Vector4 p_lhs, Vector4 p_rhs)
			{
				return p_lhs - p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sub (ref Vector4 p_lhs, Vector4 p_rhs)
			{
				p_lhs -= p_rhs;
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sub (Vector4 p_lhs, float p_rhs)
			{
				return p_lhs - Replicate(p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sub (ref Vector4 p_lhs, float p_rhs)
			{
				p_lhs -= Replicate(p_rhs);
				return p_lhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 Sub (float p_lhs, Vector4 p_rhs)
			{
				return Replicate(p_lhs) - p_rhs;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 To (this Vector4 p_this, Vector4 p_target)
			{
				return FromTo(p_this, p_target);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (Vector2 p_weight, Vector4 p_a, Vector4 p_b)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (float p_weightA, float p_weightB, Vector4 p_a, Vector4 p_b)
			{
				return p_a * p_weightA + p_b * p_weightB;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (Vector3 p_weight, Vector4 p_a, Vector4 p_b, Vector4 p_c)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_weight.z, p_a, p_b, p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (float p_weightA, float p_weightB, float p_weightC, Vector4 p_a, Vector4 p_b, Vector4 p_c)
			{
				return p_a * p_weightA + p_b * p_weightB + p_c * p_weightC;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (Vector4 p_weight, Vector4 p_a, Vector4 p_b, Vector4 p_c, Vector4 p_d)
			{
				return WeightedSum(p_weight.x, p_weight.y, p_weight.z, p_weight.w, p_a, p_b, p_c, p_d);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WeightedSum (float p_weightA, float p_weightB, float p_weightC, float p_weightD, Vector4 p_a, Vector4 p_b, Vector4 p_c, Vector4 p_d)
			{
				return p_a * p_weightA + p_b * p_weightB + p_c * p_weightC + p_d * p_weightD;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector4 WithMagnitude (this Vector4 p_this, float p_magnitude)
			{
				return p_this.normalized * p_magnitude;
			}

		#endregion
	}
}
