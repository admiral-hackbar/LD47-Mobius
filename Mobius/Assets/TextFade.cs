using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : TriggeredObject
{
    public Text text;
    public float initialDelay = 0;
    public float seconds = 1;

    protected bool countdownInitiated = false;

    private float initialCountdown = 0;
    private bool fadeInitiated = false;

    private void Start()
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
    }

    void Update()
    {
        if (!countdownInitiated)
        {
            return;
        }

        initialCountdown += Time.deltaTime;
        if (initialCountdown >= initialDelay && !fadeInitiated)
        {
            StartCoroutine(FadeTextToFullAlpha());
            fadeInitiated = true;
        }
    }

    public IEnumerator FadeTextToFullAlpha()
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        while (text.color.a < 1.0f)
        {
            text.color = new Color(text.color.r, text.color.g, text.color.b, text.color.a + (Time.deltaTime / seconds));
            yield return null;
        }
    }

    public override void trigger(TriggerSystem triggerSystem)
    {
        countdownInitiated = true;
    }
}
