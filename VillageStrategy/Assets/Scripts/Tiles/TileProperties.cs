using UnityEngine;
using System.Collections;
using System;



public class TileProperties : MonoBehaviour {

    public bool colorTesting;
    /// <summary>
    /// properties se budou brat z 5 cisel za floatem 
    /// tzn ze kazdy tile bude mit maximalne 5 vlastnosti 
    /// </summary>
    public float Seed
    {
        get; set;
    }

    public Vector2 PositionOnGrid;

    public int TileType
    {
        get
        {
            return getNumberOnFloatPosition(Seed,1);
        }
    }

    void Start()
    {
        //print(positionOnGrid + " " + seed);
        if (colorTesting)
        {
            GetComponent<SpriteRenderer>().color = Color.Lerp(Color.black, Color.white, Seed);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public int getNumberOnFloatPosition(float number,int position)
    {
        position += 1;
        string num = number.ToString();

        string test = num.Substring(position,1);

        int result = Int32.Parse(test);
        return result;
    }
}
