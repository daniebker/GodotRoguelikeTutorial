using Godot;
using GrougeLib.Models;
using GrougeLib.Types;
using GrougeLib.Components;

public partial class GodotPlayer : Node
{
	[Export]
	private Sprite2D sprite = null;

	public Entity Entity { get; private set; }

	public GodotPlayer()
	{
		Entity = new Entity(new Transform(new Vector2DI(0, 0)));
	}

	public override void _Process(double delta)
	{
		UpdatePosition();
	}

	private void UpdatePosition()
	{
		// Translate the entity transform to the sprite position.
		Vector2 position = new Vector2(Entity.Transform.Coords.X, Entity.Transform.Coords.Y);
		sprite.Offset = Grid.GridToWorld(position);
	}
}

		
