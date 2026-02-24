using UnityEngine;

public class Strawberry : Fruit
{

    void Start()
    {
        color = GetColor(fruitPrefab);
    }

    public override void DisplayFunFact() //polymorphism
    {
        funFact.text = "Fun Fact: There are about 200 seeds in every strawberry!";
        funFact.gameObject.SetActive(true);
        //Invoke("DisableFunFact", 10);
    }

}
