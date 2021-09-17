using Sandbox;
using Sandbox.UI;

namespace BombDrivers.UI
{
    public class Hud : HudEntity<RootPanel>
    {
        public static Hud Current;
        private DataPanel _data;
        public Hud() {
            if (!IsClient) return;

            Current = this;
            _data = new DataPanel();
        }

        [Event.Hotload]
        public static void OnHotReload() {
            if (!Host.IsClient) return;


        }
    }
}