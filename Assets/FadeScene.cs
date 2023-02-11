using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScene : MonoBehaviour
{
    internal bool fadeOut, fadeIn;
    public float fadeSpeed;
    public Image FadePanel;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeOut)
        {
            float fadeAlpha = FadePanel.color.a + (fadeSpeed * Time.deltaTime);
            FadePanel.color = new Color(FadePanel.color.r, FadePanel.color.g, FadePanel.color.b, fadeAlpha);
            Debug.Log(fadeAlpha);
            if (fadeAlpha >= 1)
            {
                fadeOut = false;
            }

        }
        if (fadeIn)
        {
            float fadeAlpha = FadePanel.color.a - (fadeSpeed * Time.deltaTime);
            FadePanel.color = new Color(FadePanel.color.r, FadePanel.color.g, FadePanel.color.b, fadeAlpha);
            if (fadeAlpha <= 0)
            {
                fadeIn = false;
            }

        }
    }
    public void FadeIn()
    {
        fadeIn = true; 
        FadePanel.gameObject.SetActive(true);
    }
    public void FadeOut()
    {
        fadeOut = true;
        FadePanel.gameObject.SetActive(true);
    }
}
