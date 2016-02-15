using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonActionsHandler : MonoBehaviour {

    public GameObject soilButtons;

    private List<GameObject> allTiles;

    private TileTypeHandler tileType;
    private TileProperties tileProperties;

	void Start () {
        findAllTiles();
	}
	
	void Update () {
        
        if(getSelectedTile() == null)
        {
            soilButtons.SetActive(false);
            return;
        }

        tileType = getSelectedTile().GetComponent<TileTypeHandler>();
        tileProperties = getSelectedTile().GetComponent<TileProperties>();

        switch(tileType.tileType)
        {
            case TileType.Soil:
                {

                    soilButtons.SetActive(true);
                    break;
                }
            case TileType.Water:
                {
                    soilButtons.SetActive(false);
                    break;
                }
            case TileType.None:
                {
                    soilButtons.SetActive(false);
                    break;
                }
        }

        /*
        switch (getSelectedTileType())
        {
            case TileType.Soil:
                {

                    soilButtons.SetActive(true);
                    break;
                }
            case TileType.Water:
                {
                    soilButtons.SetActive(false);
                    break;
                }
            case TileType.None:
                {
                    soilButtons.SetActive(false);
                    break;
                }
        }
        */


	}


    private TileType getSelectedTileType()
    {
        foreach(GameObject g in allTiles)
        {
            if(g.GetComponent<TileSelectionHandler>().selected)
            {
                return g.GetComponent<TileTypeHandler>().tileType;
            }
        }
        return TileType.None;
    }

    private GameObject getSelectedTile()
    {
        foreach (GameObject g in allTiles)
        {
            if (g.GetComponent<TileSelectionHandler>().selected)
            {
                return g;
            }
        }
        return null;
    }

    void findAllTiles()
    {
        allTiles = new List<GameObject>();
        allTiles.AddRange(GameObject.FindGameObjectsWithTag("Tile"));
    }
}
