using System.Collections.Generic;
using UnityEngine;

public class Smoothie : MonoBehaviour
{
    public Material material;
    private Fruit fruitObj;

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
        Dictionary<GameObject, int> map = SpawnManager.Instance.fruitSpawned;
        Color smoothieColor = new();
        float[] colorValues = new float[4];

        foreach (GameObject fruit in map.Keys)
        {
            Color color = fruitObj.GetColor(fruit);
            colorValues[0] = color.r;
            colorValues[1] = color.g;
            colorValues[2] = color.b;
            colorValues[3] = color.a;
        }

        return smoothieColor;
    }
}
