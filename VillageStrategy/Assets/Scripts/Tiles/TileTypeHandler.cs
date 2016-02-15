using UnityEngine;
using System.Collections;

[System.Serializable]
public class TypeContainer
{
    [SerializeField]
    public int minimumCoeficient;
    public int maximumCoeficient;
}

public class TileTypeHandler : MonoBehaviour {

    public TileType tileType;
    public TypeContainer soilType;
    public TypeContainer waterType;
    public TypeContainer woodsType;
    public TypeContainer mountainsType;

    TileProperties tileProperties;

	void Start () {
        tileProperties = GetComponent<TileProperties>();

        setTileType();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void setTileType()
    {
        if (tileProperties.TileType >= soilType.minimumCoeficient && tileProperties.TileType <= soilType.maximumCoeficient)
        {
            tileType = TileType.Soil;
        }

        if (tileProperties.TileType >= waterType.minimumCoeficient && tileProperties.TileType <= waterType.maximumCoeficient)
        {
            tileType = TileType.Water;
        }

        if (tileProperties.TileType >= woodsType.minimumCoeficient && tileProperties.TileType <= woodsType.maximumCoeficient)
        {
            tileType = TileType.Woods;
        }

        if (tileProperties.TileType >= mountainsType.minimumCoeficient && tileProperties.TileType <= mountainsType.maximumCoeficient)
        {
            tileType = TileType.Mountains;
        }
    }
}
