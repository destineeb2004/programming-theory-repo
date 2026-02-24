using UnityEngine;

public class Strawberry : Fruit //inheritance
{

    void Start()
    {
        color = GetColor(fruitPrefab);
    }

    public override void DisplayFunFact() //polymorphism
    {
        funFact.text = "Fun Fact: There are about 200 seeds in every strawberry!";
        funFact.gameObject.SetActive(true);

        if(funFact.text != "")
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
