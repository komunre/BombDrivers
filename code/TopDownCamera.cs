using Sandbox;

namespace BombDrivers
{
    public class TopDownCamera : Camera
    {
        public override void Update() {
            Pos = Local.Pawn.Position + new Vector3(0, 0, 500);
            Rot = Rotation.FromAxis(Vector3.Left, 90);

            FieldOfView = 80;
            Viewer = Local.Pawn;
        }
    }
}