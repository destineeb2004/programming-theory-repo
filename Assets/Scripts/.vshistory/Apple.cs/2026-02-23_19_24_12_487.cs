using UnityEngine;

public class Apple : Fruit //inheritance
{
    void Start()
    {
        color = GetColor(fruitPrefab);
    }

    public override void DisplayFunFact() //polymorphism
    {
        funFact.text = "Fun Fact: Apples are members of the rose family!";
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
