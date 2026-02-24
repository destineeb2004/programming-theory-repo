using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Fruit : MonoBehaviour
{
    public TextMeshProUGUI funFact;
    public Color color { get; protected set; } // encapsulation
    protected SpawnManager spawnManager;
    [SerializeField] protected GameObject fruitPrefab;
    public static Fruit Instance;

    void Awake()
    {
        Instance = this;
    }
    
    public virtual void DisplayFunFact()
    {
        funFact.text = "";
        funFact.gameObject.SetActive(true);
            
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
