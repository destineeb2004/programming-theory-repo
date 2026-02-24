using UnityEngine;

public class Orange : Fruit //inheritance
{
    void Start()
    {
        color = GetColor(fruitPrefab);
    }

    public override void DisplayFunFact() //polymorphism
    {
        funFact.text = "Fun Fact: The color orange is named after the fruit!";
        funFact.gameObject.SetActive(true);

        if (funFact.text != "")
        {
            CancelInvoke("DisableFunFact");
            Invoke("DisableFunFact", 10);
        }
        else
        {
            Invoke("DisableFunFact", 10);
        }
    }
}
