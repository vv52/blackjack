using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealCards : MonoBehaviour
{
    private List<CardModel> playerCards;
    private List<CardModel> dealerCards;

    private CardManager cardManager;

    public GameObject Card;

    void Awake()
    {
        DrawCards();
        DisplayCards();
        GameObject tempCard = GameObject.Instantiate(Card, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }

    void DrawCards()
    {
        playerCards = new List<CardModel>();
        dealerCards = new List<CardModel>();

        CardModel temp = new CardModel();

        for (int i = 0; i < 2; i++)
        {
            playerCards.Add(temp);
            playerCards[i].cardIndex = Random.Range(0, 51);
        
            while (cardManager.CheckIfPlayed(playerCards[i]) == true)
            {
                playerCards[i].cardIndex = Random.Range(0, 51);
            }
        }

        for (int j = 0; j < 2; j++)
        {
            dealerCards.Add(temp);
            dealerCards[j].cardIndex = Random.Range(0, 51);
        
            while (cardManager.CheckIfPlayed(dealerCards[j]) == true)
            {
                dealerCards[j].cardIndex = Random.Range(0, 51);
            }
        }
    }

    void DisplayCards()
    {
        
    }
}
