using Jaxtermg.UIFramework.Windows;

namespace Jaxtermg.UIFramework.Managers
{
	public class UIManager : IUIManager
	{
		private readonly IWindowPool windowPool;

		public WindowManager(IWindowPool pool)
		{
			windowPool = pool;
		}

		public void ShowWindow(WindowType type)
		{
			IWindow window = windowPool.GetWindow(type);
			window.Show();
		}

		public void HideWindow(IWindow window)
		{
			windowPool.ReturnWindow(window);
		}
	}
}