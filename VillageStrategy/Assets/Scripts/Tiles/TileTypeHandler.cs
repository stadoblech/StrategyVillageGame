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
        if (tileProperties.TileTypeNumerous >= soilType.minimumCoeficient && tileProperties.TileTypeNumerous <= soilType.maximumCoeficient)
        {
            tileType = TileType.Soil;
        }

        if (tileProperties.TileTypeNumerous >= waterType.minimumCoeficient && tileProperties.TileTypeNumerous <= waterType.maximumCoeficient)
        {
            tileType = TileType.Water;
        }

        if (tileProperties.TileTypeNumerous >= woodsType.minimumCoeficient && tileProperties.TileTypeNumerous <= woodsType.maximumCoeficient)
        {
            tileType = TileType.Woods;
        }

        if (tileProperties.TileTypeNumerous >= mountainsType.minimumCoeficient && tileProperties.TileTypeNumerous <= mountainsType.maximumCoeficient)
        {
            tileType = TileType.Mountains;
        }
    }
}
