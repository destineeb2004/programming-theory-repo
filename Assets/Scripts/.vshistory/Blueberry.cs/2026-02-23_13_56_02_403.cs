using UnityEngine;

public class Blueberry : Fruit
{
    public override void DisplayFunFact() //inheritance
    {
        funFact.text = "Fun Fact: Blueberries are one of the only foods that are naturally blue in color!";
        funFact.gameObject.SetActive(true);
        Invoke("DisableFunFact", 10);
    }
}
