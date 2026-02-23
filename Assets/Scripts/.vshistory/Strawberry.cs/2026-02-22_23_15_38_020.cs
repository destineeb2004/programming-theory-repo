using UnityEngine;

public class Strawberry : Fruit
{
    protected override void DisplayFunFact()
    {
        funFact.text = "Strawberries";
        funFact.gameObject.SetActive(true);
    }
}
