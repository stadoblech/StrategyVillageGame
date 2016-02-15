using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Tile : MonoBehaviour {

    static List<GameObject> allTiles;

	void Start () {
        
    }
	
	void Update () {
	
	}


    public static GameObject getSelectedTile()
    {

        allTiles = new List<GameObject>();
        allTiles.AddRange(GameObject.FindGameObjectsWithTag("Tile"));

        foreach (GameObject g in allTiles)
        {
            if (g.GetComponent<TileSelectionHandler>().selected)
            {
                return g;
            }
        }
        return null;
    }

    public static TileType getTileType(float posX, float posY)
    {

        List<GameObject> tiles = new List<GameObject>();
        tiles.AddRange(GameObject.FindGameObjectsWithTag("Tile"));

        TileProperties p;
        TileTypeHandler type;

        foreach (GameObject o in tiles)
        {
            p = o.GetComponent<TileProperties>();
            type = o.GetComponent<TileTypeHandler>();

            if (p.PositionOnGrid.x == posX && p.PositionOnGrid.y == posY)
            {
                return type.tileType;
                //return o.GetComponent<TileTypeHandler>().tileType;
            }
        }
        return TileType.None;
    }

    public static GameObject getTileAtPosition(float posX, float posY)
    {
        List<GameObject> tiles = new List<GameObject>();
        tiles.AddRange(GameObject.FindGameObjectsWithTag("Tile"));

        TileProperties p;

        foreach (GameObject o in tiles)
        {
            p = o.GetComponent<TileProperties>();

            if (p.PositionOnGrid.x == posX && p.PositionOnGrid.y == posY)
            {
                return o;
                //return o.GetComponent<TileTypeHandler>().tileType;
            }
        }
        return null;
    }

    public static List<GameObject> getObjectsAroundSelected()
    {
        List<GameObject> l = new List<GameObject>();
        GameObject o = getSelectedTile();

        if (getTileAtPosition(o.GetComponent<TileProperties>().PositionOnGrid.x+1, o.GetComponent<TileProperties>().PositionOnGrid.y) != null)
        {
            l.Add(getTileAtPosition(o.GetComponent<TileProperties>().PositionOnGrid.x + 1, o.GetComponent<TileProperties>().PositionOnGrid.y));
        }

        if (getTileAtPosition(o.GetComponent<TileProperties>().PositionOnGrid.x - 1, o.GetComponent<TileProperties>().PositionOnGrid.y) != null)
        {
            l.Add(getTileAtPosition(o.GetComponent<TileProperties>().PositionOnGrid.x - 1, o.GetComponent<TileProperties>().PositionOnGrid.y));
        }

        if (getTileAtPosition(o.GetComponent<TileProperties>().PositionOnGrid.x, o.GetComponent<TileProperties>().PositionOnGrid.y+1) != null)
        {
            l.Add(getTileAtPosition(o.GetComponent<TileProperties>().PositionOnGrid.x, o.GetComponent<TileProperties>().PositionOnGrid.y+1));
        }

        if (getTileAtPosition(o.GetComponent<TileProperties>().PositionOnGrid.x, o.GetComponent<TileProperties>().PositionOnGrid.y - 1) != null)
        {
            l.Add(getTileAtPosition(o.GetComponent<TileProperties>().PositionOnGrid.x, o.GetComponent<TileProperties>().PositionOnGrid.y - 1));
        }

        return l;
    }
}
