// SPDX-License-Identifier: MIT
// © 2024 JaxterMG <eugeny.craevsky@gmail.com>

using DG.Tweening;
using UnityEngine;

namespace UI.Windows.Configs
{
    /// <summary>
    /// Configuration class for DoTween animations.
    /// </summary>
    public class DoTweenAnimationConfig
    {
        /// <summary>
        /// Duration of the animation in seconds.
        /// </summary>
        public float Duration = 0.5f;

        /// <summary>
        /// Type of easing to be used for the animation.
        /// </summary>
        public Ease EaseType = Ease.InOutQuad;

        /// <summary>
        /// Target position for the animation.
        /// </summary>
        public Vector3 TargetPosition;

        /// <summary>
        /// Target scale for the animation. Default is Vector3.one.
        /// </summary>
        public Vector3 TargetScale = Vector3.one;

        /// <summary>
        /// Target alpha value for the animation. Default is 1f.
        /// </summary>
        public float TargetAlpha = 1f;
    }
}