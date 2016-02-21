using UnityEngine;
using System.Collections;

public class TileScriptsBehaviourHandler : MonoBehaviour {

    public bool populated;

    TileType actualType;

	void Start () {
        Invoke("initialPopulate", 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        actualType = GetComponent<TileTypeHandler>().tileType;
    }

    void initialPopulate()
    {
        if (GetComponent<TileTypeHandler>().tileType == TileType.MainHouse)
            populated = true;
        else
            populated = false;

        addBehaviourScripts();
    }

    void addBehaviourScripts()
    {
        actualType = GetComponent<TileTypeHandler>().tileType;

        gameObject.AddComponent<TileSoilBehaviour>();
        gameObject.AddComponent<TileWoodsBehaviour>();
        gameObject.AddComponent<TileWaterBehaviour>();
        gameObject.AddComponent<TileMountainBehaviour>();

        disableAllScripts();

        switch (actualType)
        {
            case (TileType.Soil):
                {
                    
                    GetComponent<TileSoilBehaviour>().enabled = true;
                    break;
                }
            case TileType.Woods:
                {
                    GetComponent<TileWoodsBehaviour>().enabled = true;
                    break;
                }
            case TileType.Water:
                {
                    GetComponent<TileWaterBehaviour>().enabled = true;
                    break;
                }
            case TileType.Mountains:
                {
                    GetComponent<TileMountainBehaviour>().enabled = true;
                    break;
                }
            case TileType.MainHouse:
                {
                    break;
                }
        }
    }

    void disableAllScripts()
    {
        GetComponent<TileSoilBehaviour>().enabled = false;
        GetComponent<TileWaterBehaviour>().enabled = false;
        GetComponent<TileWoodsBehaviour>().enabled = false;
        GetComponent<TileMountainBehaviour>().enabled = false;
    }
}

