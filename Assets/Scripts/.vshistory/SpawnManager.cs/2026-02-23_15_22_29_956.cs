using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject strawberry;
    [SerializeField] private GameObject orange;
    [SerializeField] private GameObject banana;
    [SerializeField] private GameObject apple;
    [SerializeField] private GameObject blueberry;
    [SerializeField] private GameObject plum;
    public Color strawberryColor { get; private set; }
    public Color orangeColor { get; private set; }
    public Color bananaColor { get; private set; }
    public Color appleColor { get; private set; }
    public Color blueberryColor { get; private set; }
    public Color plumColor { get; private set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        strawberryColor = strawberry.GetComponent<MeshRenderer>().sharedMaterial.color;
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
