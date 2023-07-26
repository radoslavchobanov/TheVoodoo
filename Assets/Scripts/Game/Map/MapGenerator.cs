using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject TilePrefab;
    public GameObject Map;

    public Tile[,] InitializeMap()
    {
        Tile[,] generatedMap = new Tile[Constants.MAP_WIDTH, Constants.MAP_HEIGHT];

        for (int i = 0; i < Constants.MAP_WIDTH; ++i)
        {
            for (int j = 0; j < Constants.MAP_HEIGHT; ++j)
            {
                var tileObj = Instantiate(TilePrefab, GetNextPosition(i, j), Quaternion.identity, Map.transform);
                tileObj.transform.localPosition += new Vector3(0, 0, 5);
                tileObj.name = "Tile(" + i + ", " + j + ")";
                generatedMap[i, j] = tileObj.GetComponent<Tile>();
            }
        }
        EventManager.Instance.Invoke(EventID.MapGenerated);

        return generatedMap;
    }

    private Vector2 GetNextPosition(int x, int y)
    {
        return new Vector2(x, y);
    }
}
