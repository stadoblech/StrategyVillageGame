using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class HousesCreator : MonoBehaviour {

    public int numOfHouses;

    List<GameObject> tiles;

    bool firstUpdate = false;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    if(!firstUpdate)
        {
            createHouses();
            firstUpdate = true;
        }
	}

    void createHouses()
    {

        tiles = new List<GameObject>();
        tiles.AddRange(GameObject.FindGameObjectsWithTag("Tile"));

        int timeout = 0;

        bool found = false;

        GameObject tile;

        while(!found)
        {
            int randomIndex = UnityEngine.Random.Range(0, tiles.Count);
            tile = tiles[randomIndex];

            TileProperties p = tile.GetComponent<TileProperties>();
            TileTypeHandler type = tile.GetComponent<TileTypeHandler>();

            if (Tile.getTileType(p.PositionOnGrid.x,p.PositionOnGrid.y-1) == TileType.Soil ||
                Tile.getTileType(p.PositionOnGrid.x, p.PositionOnGrid.y +1) == TileType.Soil ||
                Tile.getTileType(p.PositionOnGrid.x-1, p.PositionOnGrid.y) == TileType.Soil ||
                Tile.getTileType(p.PositionOnGrid.x+1, p.PositionOnGrid.y) == TileType.Soil
                )
            {
                found = true;
                type.tileType = TileType.MainHouse;
            }else
            {
                randomIndex = UnityEngine.Random.Range(0, tiles.Count);
            }
            timeout++;

            if(timeout > 100)
            {
                found = true;
            }
        }
    }
}
