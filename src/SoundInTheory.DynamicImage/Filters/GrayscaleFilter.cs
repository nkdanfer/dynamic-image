﻿using System;
using System.Windows.Media.Effects;
using SoundInTheory.DynamicImage.ShaderEffects;
using SoundInTheory.DynamicImage.Util;

namespace SoundInTheory.DynamicImage.Filters
{
	/// <summary>
	/// Converts the image to grayscale (using the correct colour ratios).
	/// </summary>
	public class GrayscaleFilter : ShaderEffectFilter
	{
		protected override Effect GetEffect(FastBitmap source)
		{
			return new GrayscaleEffect();
		}
	}
}
