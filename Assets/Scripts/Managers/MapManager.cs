using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : Manager
{
    public static MapManager Instance => GameManager.Instance.MapManager;

    public MapGenerator MapGenerator;

    private Tile[,] _tileMap = new Tile[Constants.MAP_WIDTH, Constants.MAP_HEIGHT];
    public Tile[,] TileMap => _tileMap;

    public override void OnEnterGame()
    {
        base.OnEnterGame();

        _tileMap = MapGenerator.InitializeMap();
    }

    public Tile GetMiddleTile()
    {
        return _tileMap[Constants.MAP_WIDTH / 2, Constants.MAP_HEIGHT / 2];
    }

    
}
