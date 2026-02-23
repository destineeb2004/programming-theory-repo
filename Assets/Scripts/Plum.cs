using UnityEngine;

public class Plum : Fruit
{
    public override void DisplayFunFact() //inheritance
    {
        funFact.text = "Fun Fact: Prunes are just dried plums!";
        funFact.gameObject.SetActive(true);
        Invoke("DisableFunFact", 10);
    }
}
