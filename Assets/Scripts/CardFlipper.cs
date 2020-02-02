using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFlipper : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    CardModel cardModel;

    public AnimationCurve scaleCurve;
    public float duration = 0.5f;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cardModel = GetComponent<CardModel>();
    }

    public void flipCard(Sprite startImage, Sprite endImage, bool showFace)
    {
        StopCoroutine(Flip(startImage, endImage, showFace));
        StartCoroutine(Flip(startImage, endImage, showFace));
    }

    IEnumerator Flip(Sprite startImage, Sprite endImage, bool showFace)
    {
        spriteRenderer.sprite = startImage;

        float time = 0f;
        while (time <= 1f)
        {
            float scale = scaleCurve.Evaluate(time);
            time = time + Time.deltaTime / duration;

            Vector3 localScale = transform.localScale;
            localScale.x = scale;
            transform.localScale = localScale;

            if (time >= 0.5f)
            {
                spriteRenderer.sprite = endImage;
            }

            yield return new WaitForFixedUpdate();
        }

        if (showFace == false)
        {
            cardModel.ToggleFace(false);
        }
        else
        {
            cardModel.ToggleFace(true);
        }
    }
}
