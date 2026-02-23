using UnityEngine;

public class Orange : Fruit
{
    public override void DisplayFunFact() //inheritance
    {
        funFact.text = "Fun Fact: The fruit came before the color!";
        funFact.gameObject.SetActive(true);
        Invoke("DisableFunFact", 10);
    }
}
