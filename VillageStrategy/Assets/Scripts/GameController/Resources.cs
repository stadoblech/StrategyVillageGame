using UnityEngine;
using System.Collections;

public class Resources : MonoBehaviour {

    public int numberOfPeopleOnStart;
    public static int currentPeople;
    public static int availablePeople;

    public float amountOfFoodOnStart;
    public static float currentFood;

    public float personConsumptionPerMinute;
    public static float actualConsumption;

	void Start () {
        currentPeople = numberOfPeopleOnStart;
        availablePeople = numberOfPeopleOnStart;
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
