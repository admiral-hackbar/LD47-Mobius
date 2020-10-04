using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFade : MonoBehaviour
{
    public Image image;
    public float seconds = 1;

    private void Start()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
        StartCoroutine(FadeTextToFullAlpha());
    }

    public IEnumerator FadeTextToFullAlpha()
    {
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1);
        while (image.color.a >= 0)
        {
            image.color = new Color(image.color.r, image.color.g, image.color.b, image.color.a - (Time.deltaTime / seconds));
            yield return null;
        }
    }
}
