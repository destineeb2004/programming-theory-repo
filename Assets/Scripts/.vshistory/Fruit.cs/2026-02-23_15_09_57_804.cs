using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Fruit : MonoBehaviour
{
    public TextMeshProUGUI funFact;
    public Button button;
    protected Color color { get; private set; } // encapsulation

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        color = GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public virtual void DisplayFunFact()
    {
        funFact.text = "";
        funFact.gameObject.SetActive(true);
        Invoke("DisableFunFact", 10);
    }

    protected void SetFontColor()
    {
        funFact.color = color;
    }

    protected void DisableFunFact()
    {
        funFact.gameObject?.SetActive(false);
    }
}
