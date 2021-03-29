﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ZkTools.Mathematics
{
	public static class Trigo
	{
		#region // ==============================[Static Variables]============================== //

			public const float CosOne = 5.403023058681397174009366074429766037e-01f;

			public const float CbrtPi = 1.464591887561523263020142527263790391e+00f;

			public const float Degree2Gradian = 1.11111111111111111111111111111111111e+00f;

			public const float Degree2Radian = 1.11111111111111111111111111111111111e+00f;

			public const float Degree2Turn = 0.00277777777777777777777777777777778e+00f;

			public const float EPowPi = 2.314069263277926900572908636794854738e+01f;

			public const float FivePiDivSix = 5.0f * Pi / 6.0f;
			
			public const float FourPiDivThree = 4.188790204786390984616857844373f;

			public const float Gradian2Degree = 0.90f;

			public const float Gradian2Radian = 0.015707963267948966192313216916e+00f;

			public const float Gradian2Turn = 0.0025f;

			public const float OneDivPi = 0.318309886183790671537767526745f;

			public const float OneDivSqrtPi = 5.641895835477562869480794515607725858e-01f;

			public const float OneDivSqrtTau = 3.989422804014326779399460599343818684e-01f;

			public const float Pi = 3.141592653589793238462643383279502884e+00f;

			public const float PiDivFour = 0.78539816339744830961566084582e+00f;

			public const float PiDivSix = 0.5235987755982989e+00f;

			public const float PiDivThree = 1.0471975511965977e+00f;

			public const float PiDivTwo = 1.570796326794896619231321691639751442e+00f;

			public const float PiSqr = 9.869604401089358618834490999876151135e+00f;

			public const float Radian2Degree = 57.29577951308232286464772187173366546e+00f;

			public const float Radian2Gradian = 63.661977236758134307553505349006e+00f;

			public const float Radian2Turn = 0.159154943091895335768883763373e+00f;
			
			public const float SinOne = 0.841470984808e+00f;

			public const float SqrtPi = 1.772453850905516027298167483341145182e+00f;
			
			public const float SqrtPiDivTwo = 1.253314137315500251207882642405522626e+00f;
			
			public const float SqrtTau = 2.5066282746310002e+00f;
			
			public const float SqrtThreeDivTwo = 0.8660254037844386e+00f;
			
			public const float SqrtTwoDivTwo = 0.7071067811865475e+00f;
			
			public const float Tau = 6.283185307179586476925286766559e+00f;

			public const float ThreePiDivFour = 2.356194490192344928846982537459627163e+00f;

			public const float Turn2Degree = 360.0f;

			public const float Turn2Gradian = 400.0f;

			public const float Turn2Radian = Tau;

			public const float TwoPiDivThree = 2.094395102393195492308428922186335256e+00f;
			
		#endregion
		
		#region // ==============================[Static Methods]============================== //

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Acos (float p_value)
			{
				return (float)Math.Acos(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AcosH (float p_value)
			{
				return MathF.Ln(p_value + MathF.Sqrt(MathF.Square(p_value) - 1.0f));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AcotH (float p_value)
			{
				return 0.5f * MathF.Ln((1 + p_value) / (p_value - 1));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AcscH (float p_value)
			{
				return MathF.Ln((1.0f + MathF.Sqrt(1.0f + MathF.Square(p_value))) / p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AsecH (float p_value)
			{
				return MathF.Ln((1.0f + MathF.Sqrt(1.0f - MathF.Square(p_value))) / p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Asin (float p_value)
			{
				return (float)Math.Asin(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AsinH (float p_value)
			{
				return MathF.Ln(p_value + MathF.Sqrt(MathF.Square(p_value) + 1.0f));
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan (float p_value)
			{
				return (float)Math.Atan(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Atan2 (float p_y, float p_x)
			{
				return (float)Math.Atan2(p_y, p_x);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float AtanH (float p_value)
			{
				return 0.5f * MathF.Ln((1.0f + p_value) / (1.0f - p_value));
			}
		
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cos (float p_value)
			{
				return (float)Math.Cos(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CosH (float p_value)
			{
				return (float)Math.Cosh(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cot (float p_value)
			{
				return 1.0f / Tan(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CotH (float p_value)
			{
				return 1.0f / TanH(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Csc (float p_value)
			{
				return 1.0f / Sin(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Cvs (float p_value)
			{
				return 1.0f - Sin(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float CscH (float p_value)
			{
				return 1.0f / SinH(p_value);
			}
			
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DegreeToRadian (float p_degree)
			{
				return p_degree * Degree2Radian;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DegreeToGradian (float p_degree)
			{
				return p_degree * Degree2Gradian;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float DegreeToTurn (float p_degree)
			{
				return p_degree * Degree2Turn;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GradianToDegree (float p_gradian)
			{
				return p_gradian * Gradian2Degree;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GradianToRadian (float p_gradian)
			{
				return p_gradian * Gradian2Radian;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float GradianToTurn (float p_gradian)
			{
				return p_gradian * Gradian2Turn;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RadianToDegree (float p_radian)
			{
				return p_radian * Radian2Degree;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RadianToGradian (float p_radian)
			{
				return p_radian * Radian2Degree;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float RadianToTurn (float p_radian)
			{
				return p_radian * Radian2Turn;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sec (float p_value)
			{
				return 1.0f / Cos(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SecH (float p_value)
			{
				return 1.0f / CosH(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Sin (float p_value)
			{
				return (float)Math.Sin(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float SinH (float p_value)
			{
				return (float)Math.Sinh(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Tan (float p_value)
			{
				return (float)Math.Tan(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float TanH (float p_value)
			{
				return (float)Math.Tanh(p_value);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float TurnToDegree(float p_radian)
			{
				return p_radian * Turn2Degree;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float TurnToGradian (float p_turn)
			{
				return p_turn * Turn2Gradian;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float TurnToRadian(float p_radian)
			{
				return p_radian * Turn2Radian;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Ver (float p_value)
			{
				return 1.0f - Cos(p_value);
			}

		#endregion
	}
}