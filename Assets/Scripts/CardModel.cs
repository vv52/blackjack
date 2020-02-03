using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel : MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;

    public bool isAce;

    public int cardValue;

    SpriteRenderer spriteRenderer;
    CardFlipper cardFlipper;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cardFlipper = GetComponent<CardFlipper>();
        cardFlipper.flipCard(cardBack, cardFace, true);
    }

    public void ToggleFace(bool showFace)
    {
        if (showFace == true)
        {
            spriteRenderer.sprite = cardFace;
        }
        else
        {
            spriteRenderer.sprite = cardBack;
        }
    }
}
