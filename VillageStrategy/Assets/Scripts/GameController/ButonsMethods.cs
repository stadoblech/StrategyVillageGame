using UnityEngine;
using System.Collections;

public class ButonsMethods : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

    public void startAutoGrow()
    {
        //Tile.getSelectedTile().GetComponent<TileScriptsBehaviourHandler>().soil.growing = true;
        Tile.getSelectedTile().GetComponent<TileSoilBehaviour>().growing = true;
    }

    public void stopAutoGrow()
    {
        //Tile.getSelectedTile().GetComponent<TileScriptsBehaviourHandler>().soil.growing = false;
        Tile.getSelectedTile().GetComponent<TileSoilBehaviour>().growing = false;
    }

    public void populateTile()
    {
        Tile.getSelectedTile().GetComponent<TileScriptsBehaviourHandler>().populated = true;
        Resources.currentPeople--;
    }

    public void changeToHouse()
    {
        Tile.getSelectedTile().GetComponent<TileTypeHandler>().tileType = TileType.MainHouse;
    }
}
