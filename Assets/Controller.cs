using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    [SerializeField] Model model;
    [SerializeField] View view;
    TMP_InputField input;

    // Start is called before the first frame update
    void Start()
    {
        GameSetup();
    }

    void GameSetup()
    {
        model.Setup();
        view.Setup();
    }

    public void SubmitGuess(int column, int row)
    {
        string userInput = input.text.ToLower(); //lowercases input since it is set to name format
        char[] chars = userInput.Trim().ToCharArray();// splits word into array of characters

        if (model.currentAttempt < 0)
        {
            LoseGame();
        }
        
        //model.UpdateCells(column, row);
        //view.UpdateView(model);
        //if (model.isValidGuessing(column, row))
        // {
        // view.UpdateView(column, row, model.UpdateCells);
        //}
    }

    void WinGame()
    {
        Debug.Log("You got the correct answer!");
    }

    void LoseGame()
    {
        if (model.currentAttempt < 0)
        {
            Debug.Log("All attempts used up. You Lost.");
        }
    }
}
