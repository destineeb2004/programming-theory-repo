using UnityEngine;

public class Apple : Fruit
{
    public override void DisplayFunFact() //inheritance
    {
        funFact.text = "Fun Fact: Apples are members of the rose family!";
        funFact.gameObject.SetActive(true);
        Invoke("DisableFunFact", 10);
    }
}
