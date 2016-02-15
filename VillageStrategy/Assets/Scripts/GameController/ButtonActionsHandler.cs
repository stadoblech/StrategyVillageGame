using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonActionsHandler : MonoBehaviour {

    public GameObject soilButtons;

    private List<GameObject> allTiles;

	void Start () {
        findAllTiles();
	}
	
	void Update () {
	    switch(getSelectedTileType())
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

    void findAllTiles()
    {
        allTiles = new List<GameObject>();
        allTiles.AddRange(GameObject.FindGameObjectsWithTag("Tile"));
    }
}
