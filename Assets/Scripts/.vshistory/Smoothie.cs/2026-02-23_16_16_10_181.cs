using UnityEngine;

public class Smoothie : MonoBehaviour
{
    private Color smoothieColor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        smoothieColor = gameObject.GetComponent<MeshRenderer>().material.color;
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
        return new Color color;
    }
}
