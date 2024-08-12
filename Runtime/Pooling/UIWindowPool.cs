// SPDX-License-Identifier: MIT
// © 2024 JaxterMG <eugeny.craevsky@gmail.com>

using JaxterMG.Pooling.ObjectPool;
using Jaxtermg.UIFramework.Windows;
using UI.Windows.Configs;
using UnityEngine;

namespace Jaxtermg.UIFramework.Pooling
{
    public class UIWindowPool : ObjectPool<IWindow>
    {
        private readonly WindowConfig windowConfig;

        public UIWindowPool(WindowConfig config)
        {
            windowConfig = config;
        }

        protected override IWindow CreateNew()
        {
            GameObject windowInstance = GameObject.Instantiate(windowConfig.WindowPrefab);
            IWindow window = windowInstance.GetComponent<IWindow>();
            window.SetConfig(windowConfig);
            return window;
        }

        public override void Return(IWindow window)
        {
            if (windowConfig.IsDisposable)
            {
                GameObject.Destroy(window as MonoBehaviour);
            }
            else
            {
                window.Hide();
                base.Return(window);
            }
        }
    }
}