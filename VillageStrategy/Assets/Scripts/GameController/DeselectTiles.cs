using UnityEngine;
using System.Collections;

public class DeselectTiles : MonoBehaviour {

    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButton(1))
        {
            TileSelectionHandler.deselectAll();
        }
	}
}
