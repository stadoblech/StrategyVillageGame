using UnityEngine;
using System.Collections;

public class Resources : MonoBehaviour {

    public int numberOfPeopleOnStart;
    public static int currentPeople;

    public float amountOfFoodOnStart;
    public static float currentFood;

    public float personConsumptionPerMinute;
    public static float actualConsumption;

	void Start () {
        currentPeople = numberOfPeopleOnStart;
        currentFood = amountOfFoodOnStart;

        InvokeRepeating("consumptionUpdate",0,1f);
	}
	
	void Update () {
        actualConsumption = personConsumptionPerMinute * currentPeople;
    }
    
    public void consumptionUpdate()
    {
        currentFood -= actualConsumption / 60;
    }
}
