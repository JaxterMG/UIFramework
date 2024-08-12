// SPDX-License-Identifier: MIT
// © 2024 JaxterMG <eugeny.craevsky@gmail.com>

using DG.Tweening;
using UI.Windows.Configs;
using UnityEngine;

namespace Jaxtermg.UIFramework.Windows
{
    /// <summary>
    /// Abstract base class for UI windows.
    /// </summary>
    public abstract class BaseWindow : MonoBehaviour, IWindow
    {
        /// <summary>
        /// Configuration for the window.
        /// </summary>
        private WindowConfig config;

        /// <summary>
        /// Sets the configuration for the window.
        /// </summary>
        /// <param name="newConfig">The new configuration to be set.</param>
        public void SetConfig(WindowConfig newConfig)
        {
            config = newConfig;
        }
        
        /// <summary>
        /// Returns the configuration for the window.
        /// </summary>
        public WindowConfig GetConfig()
        {
            return config;
        }

        /// <summary>
        /// Shows the window. Must be implemented by derived classes.
        /// </summary>
        public abstract void Show();

        /// <summary>
        /// Hides the window. Must be implemented by derived classes.
        /// </summary>
        public abstract void Hide();

        /// <summary>
        /// Plays the animation for showing the window.
        /// </summary>
        /// <param name="onComplete">Optional callback to be invoked when the animation completes.</param>
        protected void PlayShowAnimation(System.Action onComplete = null)
        {
            transform.DOMove(config.ShowAnimationConfig.TargetPosition, config.ShowAnimationConfig.Duration)
                .SetEase(config.ShowAnimationConfig.EaseType)
                .OnComplete(() => {
                    onComplete?.Invoke();
                });
            transform.DOScale(config.ShowAnimationConfig.TargetScale, config.ShowAnimationConfig.Duration)
                .SetEase(config.ShowAnimationConfig.EaseType);
        }

        /// <summary>
        /// Plays the animation for hiding the window.
        /// </summary>
        /// <param name="onComplete">Optional callback to be invoked when the animation completes.</param>
        protected void PlayHideAnimation(System.Action onComplete = null)
        {
            transform.DOMove(config.HideAnimationConfig.TargetPosition, config.HideAnimationConfig.Duration)
                .SetEase(config.HideAnimationConfig.EaseType)
                .OnComplete(() => {
                    gameObject.SetActive(false);
                    onComplete?.Invoke();
                });
            transform.DOScale(config.HideAnimationConfig.TargetScale, config.HideAnimationConfig.Duration)
                .SetEase(config.HideAnimationConfig.EaseType);
        }
    }
}