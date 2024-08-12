// SPDX-License-Identifier: MIT
// © 2024 JaxterMG <eugeny.craevsky@gmail.com>

using UI.Windows.Configs;

namespace Jaxtermg.UIFramework.Windows
{
    public interface IWindow
    {
        void Show();
        void Hide();
        void SetConfig(WindowConfig config);
        WindowConfig GetConfig();
    }
}
