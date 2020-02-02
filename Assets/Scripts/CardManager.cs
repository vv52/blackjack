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

    bool CheckIfPlayed(int cardIndex)
    {
        bool isPlayed = false;

        for (int i = 0; i < playedCards.Count; i++)
        {
            if (playedCards[i] == cardIndex)
            {
                isPlayed = true;
            }
        }

        return isPlayed;
    }
}
