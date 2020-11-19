using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageControl : MonoBehaviour
{
    public GameObject Image1;
    public GameObject Image2;
    void Start()
    {
        Image1.SetActive(false);
        Image2.SetActive(false);

    }

    IEnumerator EventCorrect()
    {
        Image1.SetActive(true);
        yield return new WaitForSeconds(2);
        Image1.SetActive(false);
    }

    IEnumerator EventWorong()
    {
        Image2.SetActive(true);
        yield return new WaitForSeconds(2);
        Image2.SetActive(false);
    }

    public void Correto()
    {
        StartCoroutine(EventCorrect());
    }

    public void Errado()
    {
        StartCoroutine(EventWorong());
    }
    
}
