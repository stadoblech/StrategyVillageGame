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

    TileProperties tileProperties;

	void Start () {
        tileProperties = GetComponent<TileProperties>();

        if (tileProperties.TileType >= soilType.minimumCoeficient && tileProperties.TileType <= soilType.maximumCoeficient)
        {
            tileType = TileType.Soil;
        }

        if (tileProperties.TileType >= waterType.minimumCoeficient && tileProperties.TileType <= waterType.maximumCoeficient)
        {
            tileType = TileType.Water;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
