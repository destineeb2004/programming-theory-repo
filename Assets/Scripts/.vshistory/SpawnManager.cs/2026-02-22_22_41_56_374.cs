using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private GameObject strawberry;
    private GameObject orange;
    private GameObject banana;
    private GameObject apple;
    private GameObject blueberry;
    private GameObject plum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnFruit(GameObject fruit)
    {
        Vector3 fruitPos = new Vector3(0, 6, 0);

        Instantiate(fruit, fruitPos, fruit.transform.rotation);
    }
}
