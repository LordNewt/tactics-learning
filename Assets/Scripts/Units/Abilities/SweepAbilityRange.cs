using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SweepAbilityRange : AbilityRange 
{
	public override bool directionOriented { get { return true; }}

	public override List<Tile> GetTilesInRange (Board board)
	{
		// Get the 3 tiles directly in front of the player
		List<Tile> tiles = new List<Tile>();
		int lateral = 3;

		Point pos = unit.tile.pos;

		Point inRange = pos;
		if (unit.dir == Directions.North || unit.dir == Directions.South) {
			int x = pos.x - 1;
			inRange.y = (unit.dir == Directions.North) ? pos.y + 1 : pos.y - 1;
			for (int i = 0; i < lateral; i++) {
				inRange.x = (x + i);
				Tile tile = board.GetTile(inRange);
				if (ValidTile(tile)) {
					tiles.Add(tile);
				}
			}
		} else if (unit.dir == Directions.East || unit.dir == Directions.West) {
			int y = pos.y - 1;
			inRange.x = (unit.dir == Directions.East) ? pos.x + 1 : pos.x - 1;
			for (int i = 0; i < lateral; i++) {
				inRange.y = (y + i);
				Tile tile = board.GetTile(inRange);
				if (ValidTile(tile)) {
					tiles.Add(tile);
				}
			}
		}
		return tiles;
	}

	bool ValidTile (Tile t)
	{
		return t != null && Mathf.Abs(t.height - unit.tile.height) <= vertical;
	}
}

