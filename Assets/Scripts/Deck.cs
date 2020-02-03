using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public GameObject[] cards;
    public GameObject deck;
    private List<int> playedCards;
    
    private SpriteRenderer spriteRenderer;

    bool deckEnd = false; 

    void DrawCard()
    {
        int temp = Random.Range(0, 51);
        
        while (playedCards.IndexOf(temp) != -1 || playedCards.Count == 51)
        {
            if (playedCards.Count == 51)
            {
                deckEnd = true;
                this.spriteRenderer = GetComponent<SpriteRenderer>();
                this.spriteRenderer.enabled = false;
                break;
            }
            temp = Random.Range(0, 51);
        }
        if (deckEnd == false)
        {
            GameObject playerCard = (GameObject)Instantiate(cards[temp]);
            playerCard.SetActive(true);

            playedCards.Add(temp);
        }
        else
        {
            //TODO: DeckReshuffle()
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        playedCards = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 28), "Deal Cards"))
        {
            DrawCard();
        }

        //TODO: add more GUI elements for "Hit", "Stay", etc.
    }
}
