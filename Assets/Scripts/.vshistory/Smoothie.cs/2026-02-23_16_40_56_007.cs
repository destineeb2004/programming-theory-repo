using UnityEngine;

public class Smoothie : MonoBehaviour
{
    [SerializeField] private GameObject smoothie;
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
        smoothieColor = new Color(1, 0, 0);
    }

    private Color MixSmoothie()
    {
        Color color = Color.red;

        return color;
    }
}
