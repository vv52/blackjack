using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardModel : MonoBehaviour
{
    public Sprite[] faces;
    public Sprite cardBack;

    public int cardIndex;
    public int handTotal;

    private int cardValue;

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

    public int CheckValue()
    {
        switch(cardIndex)
        {
            case 0:
                return 10;
                break;
            case 1:
                return 4;
                break;
            case 2:
                return 8;
                break;
            case 3:
                return 1;
                break;
            case 4:
                return 10;
                break;
            case 5:
                return 4;
                break;
            case 6:
                return 10;
                break;
            case 7:
                return 3;
                break;
            case 8:
                return 7;
                break;
            case 9:
                return 10;
                break;
            case 10:
                return 10;
                break;
            case 11:
                return 3;
                break;
            case 12:
                return 10;
                break;
            case 13:
                return 2;
                break;
            case 14:
                return 6;
                break;
            case 15:
                return 9;
                break;
            case 16:
                return 10;
                break;
            case 17:
                return 2;
                break;
            case 18:
                return 1;
                break;
            case 19:
                return 5;
                break;
            case 20:
                return 8;
                break;
            case 21:
                return 1;
                break;
            case 22:
                return 10;
                break;
            case 23:
                return 10;
                break;
            case 24:
                return 4;
                break;
            case 25:
                return 7;
                break;
            case 26:
                return 10;
                break;
            case 27:
                return 9;
                break;
            case 28:
                return 10;
                break;
            case 29:
                return 3;
                break;
            case 30:
                return 6;
                break;
            case 31:
                return 9;
                break;
            case 32:
                return 8;
                break;
            case 33:
                return 10;
                break;
            case 34:
                return 2;
                break;
            case 35:
                return 5;
                break;
            case 36:
                return 8;
                break;
            case 37:
                return 7;
                break;
            case 38:
                return 1;
                break;
            case 39:
                return 10;
                break;
            case 40:
                return 4;
                break;
            case 41:
                return 7;
                break;
            case 42:
                return 6;
                break;
            case 43:
                return 10;
                break;
            case 44:
                return 10;
                break;
            case 45:
                return 3;
                break;
            case 46:
                return 6;
                break;
            case 47:
                return 5;
                break;
            case 48:
                return 9;
                break;
            case 49:
                return 10;
                break;
            case 50:
                return 2;
                break;
            case 51:
                return 5;
                break;
            default:
                return 0;
                break;
        }
    }
}
