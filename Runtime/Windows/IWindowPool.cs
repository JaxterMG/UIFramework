// SPDX-License-Identifier: MIT
// © 2024 JaxterMG <eugeny.craevsky@gmail.com>

namespace Jaxtermg.UIFramework.Windows
{
	public interface IWindowPool
	{
		IWindow GetWindow(WindowType type);
		void ReturnWindow(IWindow window);
	}
}