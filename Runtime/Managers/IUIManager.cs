using Jaxtermg.UIFramework.Windows;

namespace Jaxtermg.UIFramework.Managers
{
	public interface IUIManager
	{
		void ShowWindow(WindowType type);
		void HideWindow(WindowType type);
	}
}