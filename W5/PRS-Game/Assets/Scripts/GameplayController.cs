using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameChoices
{
    NONE,
    ROCK,
    PAPER,
    SCISSORS
}

public class GameplayController : MonoBehaviour
{
    [SerializeField]
    private Sprite rock_Sprite, paper_Sprite, scissors_Sprite;

    [SerializeField]
    private Image playerChoice_Img, opponentChoice_Img; // Fixed spelling mistake

    [SerializeField]
    private Text infoText;

    private GameChoices player_Choice = GameChoices.NONE, opponent_Choice = GameChoices.NONE;

    private AnimationController animationController;

    void Awake()
    {
        animationController = GetComponent<AnimationController>();
    }

    public void SetChoices(GameChoices gameChoices)
    {
        switch (gameChoices)
        {
            case GameChoices.ROCK:
                playerChoice_Img.sprite = rock_Sprite;
                player_Choice = GameChoices.ROCK;
                break;
            case GameChoices.PAPER:
                playerChoice_Img.sprite = paper_Sprite;
                player_Choice = GameChoices.PAPER;
                break;
            case GameChoices.SCISSORS:
                playerChoice_Img.sprite = scissors_Sprite;
                player_Choice = GameChoices.SCISSORS;
                break;
        }
        SetOpponentChoice(); // Fixed method name
        DetermineWinner();
    }

    void SetOpponentChoice()
    { // Fixed method name
        int rnd = Random.Range(0, 3);
        switch (rnd)
        {
            case 0:
                opponent_Choice = GameChoices.ROCK;
                opponentChoice_Img.sprite = rock_Sprite;
                break;
            case 1:
                opponent_Choice = GameChoices.PAPER;
                opponentChoice_Img.sprite = paper_Sprite;
                break;
            case 2:
                opponent_Choice = GameChoices.SCISSORS;
                opponentChoice_Img.sprite = scissors_Sprite; // Fixed variable usage
                break;
        }
        
    }
    void DetermineWinner() { }
}
