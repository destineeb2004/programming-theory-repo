using UnityEngine;

public class Orange : Fruit
{
    public override void DisplayFunFact() //inheritance
    {
        funFact.text = "Fun Fact: The color orange is named after the fruit!";
        funFact.gameObject.SetActive(true);
        Invoke("DisableFunFact", 10);
    }
}
