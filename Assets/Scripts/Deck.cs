using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public GameObject[] cards;
    public GameObject deck;
    private List<int> playedCards;
    private List<int> playerCards;
    private List<int> dealerCards;
    public GameObject gameBoard;
    
    private SpriteRenderer spriteRenderer;
    private CardModel cardModel;

    bool deckEnd = false; 

    void PlayerDrawCard(int xPos, int yPos)
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
            GameObject playerCard = (GameObject)Instantiate(cards[temp], new Vector3(xPos, yPos, 0), Quaternion.identity);
            playerCard.transform.SetParent(gameBoard.transform, false);
            
            playedCards.Add(temp);
            playerCards.Add(temp);
        }
        else
        {
            //TODO: DeckReshuffle()
        }
    }

    void DealerDrawCard(int xPos, int yPos, bool showFace)
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
            GameObject dealerCard = (GameObject)Instantiate(cards[temp], new Vector3(xPos, yPos, 0), Quaternion.identity);
            dealerCard.transform.SetParent(gameBoard.transform, false);
            if (showFace == false)
            {
                //cardModel = GetComponent<CardModel>();
                //cardModel.ToggleFace(false);
            }

            playedCards.Add(temp);
            dealerCards.Add(temp);
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
        playerCards = new List<int>();
        dealerCards = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 100, 28), "Deal Cards"))
        {
            PlayerDrawCard(-2, -1);
            PlayerDrawCard(-1, -1);
            DealerDrawCard(0, 1, true);
            DealerDrawCard(1, 1, false);
        }

        //TODO: add more GUI elements for "Hit", "Stay", etc.
    }
}
