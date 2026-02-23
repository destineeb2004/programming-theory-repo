using UnityEngine;

public class MainUIHandler : MonoBehaviour
{
    private SpawnManager spawnManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
