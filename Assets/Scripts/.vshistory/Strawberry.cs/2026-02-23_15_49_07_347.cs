using UnityEngine;

public class Strawberry : Fruit
{
    [SerializeField] private GameObject prefab;

    void Start()
    {
        color = GetColor(prefab);
    }

    public override void DisplayFunFact() //inheritance
    {
        funFact.text = "Fun Fact: There are about 200 seeds in every strawberry!";
        funFact.gameObject.SetActive(true);
        Invoke("DisableFunFact", 10);
        Debug.Log(color);
    }

}
