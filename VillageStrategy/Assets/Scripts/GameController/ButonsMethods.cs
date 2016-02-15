using UnityEngine;
using System.Collections;

public class ButonsMethods : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

    public void startAutoGrow()
    {
        Tile.getSelectedTile().GetComponent<TileBehaviourScript>().soil.growing = true;
    }

    public void stopAutoGrow()
    {
        Tile.getSelectedTile().GetComponent<TileBehaviourScript>().soil.growing = false;
    }

    public void populateTile()
    {
        Tile.getSelectedTile().GetComponent<TileBehaviourScript>().populated = true;
    }
}
