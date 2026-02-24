using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject strawberry;
    [SerializeField] private GameObject orange;
    [SerializeField] private GameObject banana;
    [SerializeField] private GameObject apple;
    [SerializeField] private GameObject blueberry;
    [SerializeField] private GameObject plum;
    public Dictionary<GameObject, int> fruitSpawned = new();
    public static SpawnManager Instance;
    void Awake()
    {
        Instance = this;
    }

    public void SpawnFruit(GameObject fruit)
    {
        Vector3 fruitPos = new Vector3(0, 6, 0);

        Instantiate(fruit, fruitPos, fruit.transform.rotation);

        if (!fruitSpawned.ContainsKey(fruit))
        {
            fruitSpawned.Add(fruit, 1);
        }
        else
        {
            fruitSpawned[fruit] += 1;
        }
        
    }

    
}
