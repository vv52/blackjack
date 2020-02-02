using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<CardModel> card;
    public List<int> playedCards;

    void Awake()
    {
        playedCards = new List<int>();
    }

    void OnDraw(int cardIndex)
    {
        playedCards.Add(cardIndex);
    }

    public bool CheckIfPlayed(CardModel card)
    {
        bool isPlayed = false;

        for (int i = 0; i < playedCards.Count; i++)
        {
            if (playedCards[i] == card.cardIndex)
            {
                isPlayed = true;
            }
        }

        return isPlayed;
    }
}
