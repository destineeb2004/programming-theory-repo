using TMPro;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public TextMeshProUGUI funFact;
    protected Color color { get; private set; } // encapsulation

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
        gameObject.GetComponent<Renderer>().material.GetColor("_BaseColor");

    }
    
    public virtual void DisplayFunFact()
    {
        funFact.text = "";
        funFact.gameObject.SetActive(true);
        Invoke("DisableFunFact", 10);
    }

    protected void DisableFunFact()
    {
        funFact.gameObject?.SetActive(false);
    }
}
