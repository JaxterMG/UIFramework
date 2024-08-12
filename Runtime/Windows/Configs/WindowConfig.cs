// SPDX-License-Identifier: MIT
// © 2024 JaxterMG <eugeny.craevsky@gmail.com>

using UnityEngine;

namespace UI.Windows.Configs
{
    /// <summary>
    /// Configuration for a window in the UI framework.
    /// </summary>
    [CreateAssetMenu(fileName = "WindowConfig", menuName = "Configs/WindowConfig", order = 1)]
    public class WindowConfig : ScriptableObject
    {
        /// <summary>
        /// Prefab of the window.
        /// </summary>
        public GameObject WindowPrefab;

        /// <summary>
        /// Indicates whether the window is disposable.
        /// </summary>
        public bool IsDisposable;

        /// <summary>
        /// Configuration for the animation shown when the window is displayed.
        /// </summary>
        public DoTweenAnimationConfig ShowAnimationConfig;

        /// <summary>
        /// Configuration for the animation shown when the window is hidden.
        /// </summary>
        public DoTweenAnimationConfig HideAnimationConfig;
    }
}