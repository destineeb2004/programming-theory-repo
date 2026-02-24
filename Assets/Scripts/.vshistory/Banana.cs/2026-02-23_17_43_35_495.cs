using UnityEngine;

public class Banana : Fruit
{
    void Start()
    {
        color = GetColor(fruitPrefab);
    }

    public override void DisplayFunFact() //inheritance
    {
        funFact.text = "Fun Fact: Bananas can be black, red and blue!";
        funFact.gameObject.SetActive(true);
        //Invoke("DisableFunFact", 10);
    }
}
