using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel : MonoBehaviour
{
    public Sprite[] faces;
    public Sprite cardBack;

    public int cardIndex;

    SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ToggleFace(bool showFace)
    {
        if (showFace)
        {
            spriteRenderer.sprite = faces[cardIndex];
        }
        else
        {
            spriteRenderer.sprite = cardBack;
        }
    }
}
