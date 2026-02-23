using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Fruit : MonoBehaviour
{
    public TextMeshProUGUI funFact;
    public Color color { get; protected set; } // encapsulation
    protected SpawnManager spawnManager;
    [SerializeField] protected GameObject fruitPrefab;

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

    public Color GetColor(GameObject fruit)
    {
        return fruit.GetComponent<MeshRenderer>().sharedMaterial.color;
    }


}
