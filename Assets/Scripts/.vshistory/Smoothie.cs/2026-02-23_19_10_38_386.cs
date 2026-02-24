using System.Collections.Generic;
using UnityEngine;

public class Smoothie : MonoBehaviour
{
    public Material material;

    public void Blend()
    {
        gameObject.SetActive(true);
        material.color = MixSmoothie();
        MainUIHandler.Instance.BlendHelper();
        Debug.Log(material.color);
    }

    private Color MixSmoothie()
    {
        Dictionary<GameObject, int> map = SpawnManager.Instance.fruitSpawned;
        Color smoothieColor = new();
        float[] colorValues = new float[4];
        int totalFruit = 0;

        foreach (GameObject fruit in map.Keys)
        {
            Color color = Fruit.Instance.GetColor(fruit);
            colorValues[0] += (color.r * map[fruit]);
            colorValues[1] += (color.g * map[fruit]);
            colorValues[2] += (color.b * map[fruit]);
            colorValues[3] += (color.a * map[fruit]);

            totalFruit += map[fruit];
        }

        smoothieColor = new Color(colorValues[0] / totalFruit, colorValues[1] / totalFruit, colorValues[2] / totalFruit, colorValues[3] / totalFruit);

        return smoothieColor;
    }
}
