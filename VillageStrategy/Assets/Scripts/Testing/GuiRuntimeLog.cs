using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GuiRuntimeLog : MonoBehaviour {

    public Vector2 boxPosition;
    public Vector2 boxSize;

    private float seedToDisplay;
    private Vector2 positionOnGrid;
    private float efficiencyToDisplay;

    private List<GameObject> tiles;

	void Start () {
        tiles = new List<GameObject>();
        tiles.AddRange(GameObject.FindGameObjectsWithTag("Tile"));
	}
	
	// Update is called once per frame
	void Update() {
        Invoke("updateTilePreferences",1f);
	}

    void OnGUI()
    {
        GUI.Box(new Rect(boxPosition, boxSize),
            seedToDisplay.ToString() + "\n" +
            positionOnGrid + "\n" +
            Resources.currentFood + "\n" +
            efficiencyToDisplay);
    }

    void updateTilePreferences()
    {
        foreach (GameObject o in tiles)
        {
            if(tiles.Count == 0)
            {
                return;
            }
            if (o.GetComponent<TileSelectionHandler>().selected)
            {
                seedToDisplay = o.GetComponent<TileProperties>().Seed;
                positionOnGrid = o.GetComponent<TileProperties>().PositionOnGrid;
                efficiencyToDisplay = o.GetComponent<TileBehaviourScript>().soil.efficiency;
            }
        }
    }
}
