using Sandbox;

namespace BombDrivers {
    public class Bomb : AnimEntity {
        private float _timer = 0.0f;
        public override void Spawn() {
            SetModel("models/bomb_anim.vmdl");

            _timer = Time.Now + 5;
        }
    }
}