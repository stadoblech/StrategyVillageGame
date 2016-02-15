using UnityEngine;
using System.Collections;


/// <summary>
/// On children of Tile Gameobject
/// </summary>
public class TileIconHandler : MonoBehaviour {

    public Sprite soilIcon;
    public Sprite waterIcon;
    public Sprite treesIcon;
    public Sprite mountainIcon;

    SpriteRenderer sr;

    TileTypeHandler typeHandler;

    void Start () {
        sr = GetComponent<SpriteRenderer>();
        typeHandler = transform.parent.GetComponent<TileTypeHandler>();
        sr.material.color = Color.white;
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
            case TileType.Woods:
                {
                    sr.sprite = treesIcon;
                    break;
                }

            case TileType.Mountains:
                {
                    sr.sprite = mountainIcon;
                    break;
                }
        }
	}
}
