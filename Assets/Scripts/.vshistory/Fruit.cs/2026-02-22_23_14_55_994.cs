using TMPro;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public TextMeshProUGUI funFact;
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

    protected virtual void GetFruitColor()
    {
        fruit.gameObject.GetComponent<Renderer>().material.color = color;
    }

    protected virtual void DisplayFunFact()
    {
        funFact.text = "";
        funFact.gameObject.SetActive(true);
        Invoke("DisableFunFact", 10);
    }

    private void DisableFunFact()
    {
        funFact.gameObject?.SetActive(false);
    }
}
