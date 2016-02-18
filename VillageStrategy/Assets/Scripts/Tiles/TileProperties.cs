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

    public int TileTypeNumerous
    {
        get
        {
            return getNumberOnFloatPosition(Seed,1);
        }
    }

    public int tileEfficiency
    {
        get
        {
            return getNumberOnFloatPosition(Seed,2,2);
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

        if (result == 0)
            result = 1;
        return result;
    }

    public int getNumberOnFloatPosition(float number, int position,int length)
    {
        position += 1;
        string num = number.ToString();

        string test = num.Substring(position, length);

        int result = Int32.Parse(test);

        if (result < 10)
            result += 10;
        return result;
    }


}
