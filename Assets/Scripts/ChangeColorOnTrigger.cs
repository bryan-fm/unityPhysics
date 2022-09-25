using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        Color randomlySelectedColor = GetRandomColorWithAlpha();
        GetComponent<Renderer>().material.color = randomlySelectedColor;
    }

    private Color GetRandomColorWithAlpha()
    {
        return new Color (
        UnityEngine.Random.Range(0f,1f),
        UnityEngine.Random.Range(0f,1f),
        UnityEngine.Random.Range(0f,1f),
        0.25f);
    }
}
