using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject strawberry;
    [SerializeField] private GameObject orange;
    [SerializeField] private GameObject banana;
    [SerializeField] private GameObject apple;
    [SerializeField] private GameObject blueberry;
    [SerializeField] private GameObject plum;

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

    public Color GetColor(GameObject fruit)
    {
        return fruit.GetComponent<MeshRenderer>().sharedMaterial.color;
    }
}
