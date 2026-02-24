using UnityEngine;

public class Plum : Fruit //inheritance
{
    void Start()
    {
        color = GetColor(fruitPrefab);
    }

    public override void DisplayFunFact() //polymorphism
    {
        funFact.text = "Fun Fact: Prunes are just dried plums!";
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
