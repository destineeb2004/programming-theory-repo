using UnityEngine;

public class Fruit : MonoBehaviour
{
    protected string funFact { get; private set; }
    protected Color color { get; private set; } // encapsulation

    protected GameObject fruit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetFruitColor()
    {
        fruit.gameObject.GetComponent<Renderer>().material.color = color;
    }

    private void SetFunFact()
    {
        funFact = "";
    }
}
