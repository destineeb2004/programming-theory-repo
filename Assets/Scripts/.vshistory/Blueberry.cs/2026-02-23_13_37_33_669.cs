using UnityEngine;

public class Blueberry : Fruit
{
    public override void DisplayFunFact() //inheritance
    {
        funFact.text = "There are about 200 seeds in every strawberry!";
        funFact.gameObject.SetActive(true);
        Invoke("DisableFunFact", 10);
    }
}
