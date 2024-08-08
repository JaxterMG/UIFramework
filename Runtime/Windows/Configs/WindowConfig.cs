using UnityEngine;

namespace UI.Windows.Configs
{
	[CreateAssetMenu(fileName = "WindowConfig", menuName = "Configs/WindowConfig", order = 1)]
	public class WindowConfig : ScriptableObject
	{
		public GameObject windowPrefab;
		public bool IsDisposable;
		public DoTweenAnimationConfig showAnimationConfig;
		public DoTweenAnimationConfig hideAnimationConfig;
	}
}
