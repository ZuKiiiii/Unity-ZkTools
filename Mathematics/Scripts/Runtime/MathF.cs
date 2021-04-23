﻿using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics
{
	public static class MathF
	{
		#region // ==============================[Static Variables]============================== //

			public const float E = 2.718281828459045235360287471352662497e+00f;

			public const float EPowMinusHalf = 6.065306597126334236037995349911804534e-01f;

			public const float EPowMinusOne = 3.678794411714423215955237701614608674e-01f;

			public const float GoldenRatio = 1.618033988749894848204586834365638117e+00f; 

			public const float Half = 5e-01f;

			public const float OneDivE = EPowMinusOne;
			
			public const float SqrtE = 1.648721270700128146848650787814163571e+00f;

			public const float SqrtThree = 1.732050807568877293527446341506e+00f;

			public const float SqrtTwo = 1.414213562373095048801688724209698078e+00f;

			public const float Third = 3.333333333333333333333333333333333333e-01f;

			public const float ThreeDivFour = 7.500000000000000000000000000000000000e-01f;

		#endregion

		#region // ==============================[Static Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Abs (float p_value)
			{
				return Math.Abs(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cbrt (float p_value)
			{
				return Root(p_value, 3);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Ceil (float p_value)
			{
				return (float)Math.Ceiling(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int CeilToInt (float p_value)
			{
				return (int)Ceil(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Clamp (float p_value, float p_min = 0.0f, float p_max = 1.0f)
			{
				return Min(Max(p_value, p_min), p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cube (float p_value)
			{
				return Square(p_value) * p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Distance (float p_lhs, float p_rhs)
			{
				return Abs(p_lhs - p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DistanceSqr (float p_lhs, float p_rhs)
			{
				return Square(p_lhs - p_rhs);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Exp (float p_value)
			{
				return (float)Math.Exp(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Floor (float p_value)
			{
				return (float)Math.Floor(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int FloorToInt (float p_value)
			{
				return (int)Floor(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Frac (float p_value)
			{
				return p_value - Floor(p_value);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Fractional (float p_value)
			{
				return p_value - Trunc(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Inv (float p_value)
			{
				return 1.0f / p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float InverseLerp (float p_a, float p_b, float p_value)
			{
				return (p_value - p_a) / (p_b - p_a);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float InverseLerpClamped (float p_a, float p_b, float p_value, float p_min = 0.0f, float p_max = 1.0f)
			{
				return Clamp(InverseLerp(p_a, p_b, p_value), p_min, p_max);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float InvSqrt (float p_value)
			{
				return 1.0f / Sqrt(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyEqual (float p_lhs, float p_rhs, float p_tolerance = float.Epsilon)
			{
				return IsNearlyZero(p_lhs - p_rhs, p_tolerance);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNearlyZero (float p_value,  float p_tolerance = float.Epsilon)
			{
				return Abs(p_value) <= p_tolerance;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNegative (float p_value)
			{
				return p_value < 0.0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsNegativeOrZero (float p_value)
			{
				return p_value <= 0.0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsPositive (float p_value)
			{
				return p_value > 0.0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsPositiveOrZero (float p_value)
			{
				return p_value >= 0.0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool IsZero (float p_value)
			{
				return p_value == 0.0f;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Lerp (float p_a, float p_b, float p_t)
			{
				return p_a + (p_b - p_a) * p_t;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float LerpClamped (float p_a, float p_b, float p_t)
			{
				return Lerp(p_a, p_b, Clamp(p_t));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Ln (float p_value)
			{
				return LogE(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Log (float p_value, float p_base)
			{
				return (float)Math.Log(p_value, p_base);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Log2 (float p_value)
			{
				return Log(p_value, 2.0f);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Log10 (float p_value)
			{
				return (float)Math.Log10(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float LogE (float p_value)
			{
				return (float)Math.Log(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (float p_a, float p_b)
			{
				return Math.Max(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (float p_a, float p_b, float p_c)
			{
				return Max(Max(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Max (params float[] p_values)
			{
				return p_values.Max();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (float p_a, float p_b)
			{
				return Math.Min(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (float p_a, float p_b, float p_c)
			{
				return Min(Min(p_a, p_b), p_c);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Min (params float[] p_values)
			{
				return p_values.Min();
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Modf (float p_value, out float p_intPart)
			{
				Modf(p_value, out p_intPart, out float fractPart);
				return fractPart;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Modf (float p_value, out int p_intPart)
			{
				Modf(p_value, out p_intPart, out float fractPart);
				return fractPart;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Modf (float p_value, out float p_intPart, out float p_fracPart)
			{
				p_intPart = Floor(p_value);
				p_fracPart = p_value - p_intPart;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static void Modf (float p_value, out int p_intPart, out float p_fracPart)
			{
				p_intPart = FloorToInt(p_value);
				p_fracPart = p_value - p_intPart;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float MoveTowards (float p_current, float p_target, float p_maxDelta)
			{
				return Abs(p_target - p_current) <=  p_maxDelta ? p_target : p_current + SignPos(p_target - p_current) * p_maxDelta;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Negate (float p_value)
			{
				return 1.0f - p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float PingPong (float p_value, float p_length)
			{
				return p_length - Mathf.Abs(Repeat(p_value, p_length * 2f) - p_length);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Pow (float p_base, float p_exponent)
			{
				return (float)Math.Pow(p_base, p_exponent);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float QuadraticDelta (float p_a, float p_b, float p_c)
			{
				return Square(p_b) - 4 * p_a * p_c;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Quartic (float p_value)
			{
				return p_value * p_value * p_value * p_value;
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Quintic (float p_value)
			{
				return p_value * p_value * p_value * p_value * p_value;
			}
			
			public static float[]  QuadraticEquation (float p_a, float p_b, float p_c)
			{
				float delta = QuadraticDelta(p_a, p_b, p_c);
				switch (Sign(delta))
				{
					case 0 : return new float[] {-p_b / (2 * p_a)};
					case 1:
					{
						float sqrtDelta = Sqrt(delta);
						float a2 = 2 * p_a;
						return new float[] {-p_b -  sqrtDelta / a2, -p_b + sqrtDelta / a2};
					}
				}
				return new float[] {};
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Remainder (float p_a, float p_b)
			{
				return (float)Math.IEEERemainder(p_a, p_b);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Remap (float p_value, float p_inMin, float p_inMax, float p_outMin, float p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerp(p_inMin, p_inMax, p_value));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RemapClamped (float p_value, float p_inMin, float p_inMax, float p_outMin, float p_outMax)
			{
				return Lerp(p_outMin, p_outMax, InverseLerpClamped(p_inMin, p_inMax, p_value));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Repeat (float p_value, float p_length)
			{
				return Clamp(p_value - Mathf.Floor(p_value / p_length) * p_length, 0.0f, p_length);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Round (float p_value)
			{
				return (float)Math.Round(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int RoundToInt (float p_value)
			{
				return (int)Round(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Root (float p_value, float p_rootExponent)
			{
				return Pow(p_value, 1.0f / p_rootExponent);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Root (float p_value, int p_rootExponent)
			{
				return Pow(p_value, 1.0f / p_rootExponent);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static int Sign (float p_value)
			{
				return Math.Sign(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SignPos (float p_value)
			{
				return p_value >= 0.0 ? 1f : -1f;
			}

			public static float SmoothDamp (float p_current, float p_target, ref float p_currentVelocity, float p_smoothTime, float p_deltaTime, float p_maxSpeed = float.PositiveInfinity)
			{
				p_smoothTime = Max(0.0001F, p_smoothTime);
				float omega = 2F / p_smoothTime;

				float x = omega * p_deltaTime;
				float exp = 1F / (1F + x + 0.479999989271164f * Square(x) + 0.234999999403954f * Cube(x));
				float change = p_current - p_target;
				float originalTo = p_target;

				// Clamp maximum speed
				float maxChange = p_maxSpeed * p_smoothTime;
				change = Clamp(change, -maxChange, maxChange);
				p_target = p_current - change;

				float temp = (p_currentVelocity + omega * change) * p_deltaTime;
				p_currentVelocity = (p_currentVelocity - omega * temp) * exp;
				float output = p_target + ( change + temp ) * exp;

				// Prevent overshooting
				if (originalTo - p_current > 0.0F == output > originalTo) 
				{
					output = originalTo;
					p_currentVelocity = (output - originalTo) / p_deltaTime;
				}

				return output;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sqrt (float p_value)
			{
				return (float)Math.Sqrt(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Square (float p_value)
			{
				return p_value * p_value;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Trunc (float p_value)
			{
				return (float)Math.Truncate(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float TruncToInt (float p_value)
			{
				return (int)Trunc(p_value);
			}

		#endregion
	}
}
// copy sign