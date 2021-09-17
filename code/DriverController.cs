using Sandbox;

namespace BombDrivers
{
    public class DriverController : BasePlayerController
    {
        public override void Simulate() {
            EyePosLocal = Position;
            EyeRot = Rotation.FromAxis(Vector3.Up, 0f);
            var vel = EyeRot.Forward * Input.Forward;
            vel += EyeRot.Left * Input.Left;
            vel *= 10;

            if (vel != 0) {
                Log.Info(vel);
            }

            WishVelocity = vel;
            Velocity = vel;
            BaseVelocity = vel;

            var collide = Trace.Ray(Position, Position + vel).Ignore(Pawn).Run();
            if (!collide.Hit) {
                Position += vel;   
            }
        }
    }
}