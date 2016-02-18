using UnityEngine;
using System.Collections;

[System.Serializable]
public class SoilTile
{
    [SerializeField]
    public bool growing;

    public void update()
    {
        if(growing)
        {
            
        }
    }

    public void startGrow()
    {
        growing = true;
    }
}

public class TileBehaviourScript : MonoBehaviour {

    public bool populated;
    public SoilTile soil;



	void Start () {
        Invoke("initialPopulate",0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        switch(GetComponent<TileTypeHandler>().tileType)
        {
            case TileType.Soil:
                {
                    soil.update();
                    break;
                }
        }
    }

    void initialPopulate()
    {
        if (GetComponent<TileTypeHandler>().tileType == TileType.MainHouse)
            populated = true;
        else
            populated = false;
    }
}
