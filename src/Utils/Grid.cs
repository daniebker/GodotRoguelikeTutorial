using Godot;

public class Grid
{
	public static readonly Vector2 TileSize = new Vector2(16, 16);

	public static Vector2 GridToWorld(Vector2 gridPos)
	{
		Vector2 worldPos = gridPos * TileSize;
		return worldPos;
	}

	public static Vector2 WorldToGrid(Vector2 worldPos)
	{
		Vector2 gridPos = worldPos / TileSize;
		return gridPos;
	}
}
