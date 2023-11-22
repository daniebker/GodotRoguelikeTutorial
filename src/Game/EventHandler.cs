using GrougeLib.Input;
using GrougeLib.Input.Actions;
using Godot;

public partial class EventHandler : Node
{
	private GodotPlayer player = null;
	private InputHandler inputHandler = null;
	
	public  override void _Ready() {
		player = GetNode<GodotPlayer>("../Player");
		inputHandler = new GameInputHandler(player.Entity);
	}

	// This is the layer that interacts with the lib. So what ever is transposing the lib
	// to the game should be here. i.e. taking the Entity transform position and then updating the sprite position.
	public override void _Process(double delta)
	{
		Action action = null;
		
		if (Input.IsActionJustPressed("ui_up"))
		{
			action = inputHandler.HandleInput(InputKey.Up);
		}
		else if (Input.IsActionJustPressed("ui_down"))
		{
			action = inputHandler.HandleInput(InputKey.Down);
		}
		else if (Input.IsActionJustPressed("ui_left"))
		{
			action = inputHandler.HandleInput(InputKey.Left);
		}
		else if (Input.IsActionJustPressed("ui_right"))
		{
			action = inputHandler.HandleInput(InputKey.Right);
		}

		if (Input.IsActionJustPressed("ui_cancel"))
		{
			action = inputHandler.HandleInput(InputKey.Esc);
		}

		if(action != null) {
			action.Execute();
		}
	}
}
