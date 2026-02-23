using UnityEngine;

public class Strawberry : Fruit
{
    public override void DisplayFunFact()
    {
        funFact.text = "There are about 200 seeds in every strawberry!";
        funFact.gameObject.SetActive(true);
    }
}
