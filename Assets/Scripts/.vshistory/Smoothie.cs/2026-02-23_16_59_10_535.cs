using UnityEngine;

public class Smoothie : MonoBehaviour
{
    public Material material;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Blend()
    {
        gameObject.SetActive(true);
        material.color = MixSmoothie();
    }

    private Color MixSmoothie()
    {
        Color color = Color.red;

        return color;
    }
}
