using UnityEngine;

public class Smoothie : MonoBehaviour
{
    [SerializeField] private GameObject smoothie;
    [SerializeField] private Renderer renderer;
    private Color smoothieColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        smoothieColor = smoothie.GetComponent<MeshRenderer>().sharedMaterial.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Blend()
    {
        gameObject.SetActive(true);
        smoothieColor = MixSmoothie();
    }

    private Color MixSmoothie()
    {
        Color color = Color.red;

        return color;
    }
}
