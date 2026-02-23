using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Fruit : MonoBehaviour
{
    public TextMeshProUGUI funFact;
    protected Color color { get; set; } // encapsulation

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
