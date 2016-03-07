using UnityEngine;
using System.Collections;

public class ButonsMethods : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

    public void startAutoGrow()
    {
        Tile.getSelectedTile().GetComponent<TileSoilBehaviour>().growing = true;
    }

    public void stopAutoGrow()
    {
        Tile.getSelectedTile().GetComponent<TileSoilBehaviour>().growing = false;
    }

    public void populateTile()
    {
        Tile.getSelectedTile().GetComponent<TileScriptsBehaviourHandler>().populated = true;
        Resources.availablePeople--;
    }

    public void changeToHouse()
    {
        Tile.getSelectedTile().GetComponent<TileTypeHandler>().tileType = TileType.MainHouse;
    }
}
