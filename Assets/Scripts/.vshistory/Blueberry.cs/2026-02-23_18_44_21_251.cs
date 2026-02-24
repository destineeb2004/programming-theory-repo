using UnityEngine;

public class Blueberry : Fruit
{
    void Start()
    {
        color = GetColor(fruitPrefab);
    }

    public override void DisplayFunFact() //polymorphism
    {
        funFact.text = "Fun Fact: Blueberries are one of the only foods that are naturally blue in color!";
        funFact.gameObject.SetActive(true);
        //Invoke("DisableFunFact", 10);
    }
}
