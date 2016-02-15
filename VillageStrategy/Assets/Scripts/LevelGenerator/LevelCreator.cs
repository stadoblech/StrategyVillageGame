using UnityEngine;
using System.Collections;

public  class Tile
{
    public Vector2 position;
    public float seed;

    public Tile()
    {
        position = new Vector2();
    }
}

/// <summary>
/// pro 8 x 8 pivot by mel byt na [-6,-3]
/// </summary>
public class LevelCreator : MonoBehaviour {

    public GameObject tile;
    public int mapSize;
    public float tileDistance;


    float tileSize;
    public Vector3 pivot;

    public Tile[,] map;

	void Awake () {
        map = new Tile[mapSize, mapSize];
        tileSize = tile.GetComponent<SpriteRenderer>().bounds.size.x;
        pivot = calculatePivotPosition();
        createMap();
    }

	void Update () {
    }


    private void createMap()
    {
        Vector3 actulalTilePosition = new Vector3();

        for(int x = 0;x<map.GetLength(0);x++)
        {
            actulalTilePosition.x = x * (tileSize + tileDistance);
            for(int y = 0;y<map.GetLength(1);y++)
            {
                Vector3 pos = new Vector2(actulalTilePosition.x,actulalTilePosition.y + y * (tileSize+tileDistance));
                map[x, y] = new Tile();
                map[x, y].position = pos + pivot;
            }
        }

        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                GameObject o = (GameObject)Instantiate(tile,map[x,y].position,Quaternion.identity);
                TileProperties p = o.GetComponent<TileProperties>();
                //o.GetComponent<TileProperties>().seed = getSeed(x,y);
                p.Seed = getSeed(x,y);
                p.PositionOnGrid = new Vector2(x,y);
            }
        }
    }

    float getSeed(int x,int y)
    {
        float r = Random.Range(0f,1f);
        return Mathf.PerlinNoise((float)(x + r), (float)(y + r));
    }

    private Vector3 calculatePivotPosition()
    {
        Camera cam = Camera.main;
        float height = 2 * cam.orthographicSize;
        float width = (height * cam.aspect)/2;

        float posY = -(((tileSize*mapSize) + (tileDistance*mapSize-1)) / 2);
        float posX = -width + (2*tileSize);


        return new Vector3(posX,posY);
    }
}
