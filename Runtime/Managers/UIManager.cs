using System.Collections.Generic;
using JaxterMG.Pooling.ObjectPool;
using Jaxtermg.UIFramework.Pooling;
using Jaxtermg.UIFramework.Windows;
using UI.Windows.Configs;

namespace Jaxtermg.UIFramework.Managers
{
	public class UIManager
	{
		private readonly Dictionary<WindowConfig, ObjectPool<IWindow>> windowPools = new Dictionary<WindowConfig, ObjectPool<IWindow>>();

		public void InitializeWindowPool(WindowConfig config)
		{
			if (!windowPools.ContainsKey(config))
			{
				windowPools[config] = new UIWindowPool(config);
			}
		}

		public void ShowWindow(WindowConfig config)
		{
			IWindow window = windowPools[config].Get();
			window.Show();
		}

		public void HideWindow(WindowConfig config)
		{
			IWindow window = windowPools[config].Get();
			windowPools[config].Return(window);
		}
	}
}