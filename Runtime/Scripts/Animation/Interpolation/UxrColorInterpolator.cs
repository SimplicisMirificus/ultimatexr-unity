// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UxrColorInterpolator.cs" company="VRMADA">
//   Copyright (c) VRMADA, All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using UnityEngine;

namespace UltimateXR.Animation.Interpolation
{
    /// <summary>
    ///     Interpolator for <see cref="Color" />.
    /// </summary>
    public class UxrColorInterpolator : UxrVarInterpolator<Color>
    {
        #region Constructors & Finalizer

        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="smoothDamp">Smooth damp for interpolation [0.0, 1.0] where 0.0 means no smoothing</param>
        /// <param name="useStep">Whether to use step interpolation, where the interpolation will always return the start value</param>
        public UxrColorInterpolator(float smoothDamp = 0.0f, bool useStep = false) : base(smoothDamp, useStep)
        {
        }

        #endregion

        #region Protected Overrides UxrVarInterpolator<Color>

        /// <inheritdoc />
        protected override Color GetInterpolatedValue(Color a, Color b, float t)
        {
            return Color.Lerp(a, b, t);
        }

        #endregion

        #region Public Types & Data

        /// <summary>
        ///     Default interpolator with smoothing.
        /// </summary>
        public static readonly UxrColorInterpolator DefaultInterpolator = new UxrColorInterpolator(0.0f, false);

        #endregion
    }
}