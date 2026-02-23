using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI funFact;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void DisplayFunFact()
    {
        funFact.gameObject.SetActive(true);
        Invoke()
    }

    private void DisableFunFact()
    {
        funFact.
    }
}
