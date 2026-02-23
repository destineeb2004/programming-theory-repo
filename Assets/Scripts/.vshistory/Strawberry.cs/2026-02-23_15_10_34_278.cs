using UnityEngine;

public class Strawberry : Fruit
{

    void Start()
    {
        
    }

    public override void DisplayFunFact() //inheritance
    {
        funFact.text = "Fun Fact: There are about 200 seeds in every strawberry!";
        funFact.gameObject.SetActive(true);
        Invoke("DisableFunFact", 10);
        PrintColor();
    }

    private void PrintColor()
    {
        Debug.Log(color);
    }
}
