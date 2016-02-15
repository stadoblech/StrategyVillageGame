using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TileSelectionHandler : MonoBehaviour {


    public GameObject selectionBorder;

    public static bool isTileSelected;

    public bool selected
    {
        get; set;
    }

    private static List<GameObject> tiles;

    private static string selectionObjectName = "selected";
    void Start()
    {
        tiles = new List<GameObject>();
        tiles.AddRange(GameObject.FindGameObjectsWithTag("Tile"));
    }

    // Update is called once per frame
    void Update () {

    }

    void OnMouseDown()
    {
        deselectAll();
        selected = true;

        GameObject g = (GameObject)Instantiate(selectionBorder,transform.position,Quaternion.identity);
        g.transform.name = selectionObjectName;
        g.transform.parent = gameObject.transform;
        isTileSelected = true;
    }

    public static void deselectAll()
    {
        foreach(GameObject g in tiles)
        {
            g.GetComponent<TileSelectionHandler>().selected = false;
            foreach (Transform t in g.transform)
            {
                isTileSelected = false;
                if(t.name == selectionObjectName)
                Destroy(t.gameObject);
            }
        }
    }
    

}
