using UnityEngine;

public class Strawberry : Fruit
{
    public override void DisplayFunFact()
    {
        funFact.text = "Strawberries";
        funFact.gameObject.SetActive(true);
    }
}
