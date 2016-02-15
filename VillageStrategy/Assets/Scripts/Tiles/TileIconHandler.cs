using UnityEngine;
using System.Collections;

public class TileIconHandler : MonoBehaviour {

    public Sprite soilIcon;
    public Sprite waterIcon;

    SpriteRenderer sr;

    TileTypeHandler typeHandler;

    void Start () {
        sr = GetComponent<SpriteRenderer>();
        typeHandler = transform.parent.GetComponent<TileTypeHandler>();

        //GetComponent<SpriteRenderer>().color = Color.Lerp(Color.black, Color.white, transform.parent.GetComponent<TileProperties>().Seed);
    }
	
	// Update is called once per frame
	void Update () {
	    switch(typeHandler.tileType)
        {
            case TileType.Soil:
                {
                    sr.sprite = soilIcon;
                    break;
                }
            case TileType.Water:
                {
                    sr.sprite = waterIcon;
                    break;
                }
        }
	}
}
