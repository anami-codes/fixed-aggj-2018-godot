using System;
using Godot;

namespace VIRUS.Game
{
	public class PlayerController : KinematicBody2D
	{
		[Export] public float speed = 1.0f;

		public override void _Ready()
		{
		}

		public override void _Process(float delta)
		{
			GetInput();
		}

		public override void _PhysicsProcess(float delta)
		{
			MoveAndCollide( m_dir * speed );
		}
		
		private void GetInput()
		{
			m_dir = Vector2.Zero;
			
			if ( Input.IsActionPressed( "player_right" ) )
				m_dir.x = 1.0f;
			else if ( Input.IsActionPressed( "player_left" ) )
				m_dir.x = -1.0f;

			if ( Input.IsActionPressed( "player_up" ) )
				m_dir.y = -1.0f;
			else if ( Input.IsActionPressed( "player_down" ) )
				m_dir.y = 1.0f;

			m_dir = m_dir.Normalized();
		}

		private Vector2 m_dir;
	}
}