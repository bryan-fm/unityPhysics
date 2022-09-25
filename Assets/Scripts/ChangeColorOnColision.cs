using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnColision : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    private void OnCollisionEnter(Collision collision)
    {
        source.PlayOneShot(clip);
        Color randomlySelectedColor = GetRandomColor();
        GetComponent<Renderer>().material.color = randomlySelectedColor;
        
    }

    private Color GetRandomColor()
    {
        return new Color (
        UnityEngine.Random.Range(0f,1f),
        UnityEngine.Random.Range(0f,1f),
        UnityEngine.Random.Range(0f,1f));
    }
}
