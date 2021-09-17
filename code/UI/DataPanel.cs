using Sandbox;
using Sandbox.UI;

namespace BombDrivers.UI
{
    public class DataPanel : Panel
    {
        private Label _status;
        private Label _score;
        public DataPanel() {
            StyleSheet.Load("MinimalHud.scss");
            Parent.AddChild<ChatBox>();
            _status = AddChild<Label>();
            _score = AddChild<Label>();

            _status.AddClass("status");
            _score.AddClass("score");
        }

        public override void Tick() {
            _status.Text = Local.Pawn.LifeState == LifeState.Alive ? "Alive" : "Dead";

            _score.Text = Local.Client.GetScore<int>("killed").ToString();
        }
    }
}