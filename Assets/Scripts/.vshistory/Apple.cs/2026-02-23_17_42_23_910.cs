using UnityEngine;

public class Apple : Fruit
{
    void Start()
    {
        color = GetColor(fruitPrefab);
    }

    public override void DisplayFunFact() //inheritance
    {
        funFact.text = "Fun Fact: Apples are members of the rose family!";
        funFact.gameObject.SetActive(true);
        if (funFact.text != "")
        {
            CancelInvoke();
            Invoke("DisableFunFact", 10);
        }
        else
        {
            Invoke("DisableFunFact", 10);
        }
    }
}
