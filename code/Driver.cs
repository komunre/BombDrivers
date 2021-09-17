using Sandbox;
using System;
using System.Linq;

namespace BombDrivers
{
	partial class Driver : Player
	{
		public override void Respawn()
		{
			SetModel( "models/bomb_dispenser.vmdl" );
			EnableDrawing = true;

			//
			// Use WalkController for movement (you can make your own PlayerController for 100% control)
			//
			Controller = new DriverController();

			//
			// Use StandardPlayerAnimator  (you can make your own PlayerAnimator for 100% control)
			//
			Animator = null;

			//
			// Use ThirdPersonCamera (you can make your own Camera for 100% control)
			//
			Camera = new TopDownCamera();

			EnableAllCollisions = true;
			EnableDrawing = true;
			EnableHideInFirstPerson = false;
			EnableShadowInFirstPerson = true;

			base.Respawn();
		}

		/// <summary>
		/// Called every tick, clientside and serverside.
		/// </summary>
		public override void Simulate( Client cl )
		{
			base.Simulate( cl );

			//
			// If you have active children (like a weapon etc) you should call this to 
			// simulate those too.
			//
			SimulateActiveChild( cl, ActiveChild );

			//
			// If we're running serverside and Attack1 was just pressed, spawn a ragdoll
			//
			if ( IsServer && Input.Pressed( InputButton.Jump ) )
			{
				var bomb = new Bomb();
				bomb.Position = Position;
			}
		}

		public override void OnKilled()
		{
			base.OnKilled();

			EnableDrawing = false;
		}
	}
}
