using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCard : MonoBehaviour
{
    private CardManager cardManager;
    private CardModel cardModel;

    public GameObject Card;

    void Awake()
    {
        cardModel.cardIndex = Random.Range(0, 51);
        while (cardManager.CheckIfPlayed(cardModel) == true)
        {
            cardModel.cardIndex = Random.Range(0, 51);
        }

        GameObject card = Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
