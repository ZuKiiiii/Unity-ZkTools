﻿using System.Runtime.CompilerServices;

namespace ZkTools.Mathematics.Angles.Extensions
{
	public static class FloatX
	{
		#region ==============================[Static Methods]==============================

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static float Inv (this float p_this)
			{
				return MathF.Inv(p_this);
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Degree ToDegree (this float p_this)
			{
				return p_this;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Gradian ToGradian (this float p_this)
			{
				return p_this;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Radian ToRadian (this float p_this)
			{
				return p_this;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Turn ToTurn (this float p_this)
			{
				return p_this;
			}

		#endregion
	}
}