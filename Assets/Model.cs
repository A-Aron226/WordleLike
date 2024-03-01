using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class Model : MonoBehaviour
{
    public int[,] grid;
    public int currentAttempt = 6;
    [SerializeField] TextAsset possibleAnswers;
    [SerializeField] TextAsset allowedWords;

    public void Setup()
    {
        string[] pWords = possibleAnswers.ToString().Split("\n"); //Randomizes word from list
        string[] aWords = allowedWords.ToString().Split("\n");

        Debug.Log(pWords[Random.Range(0, pWords.Length)]);
        Debug.Log(aWords[Random.Range(0, aWords.Length)]);

        grid = new int[6, 5];
    }

    public bool isValidGuessing(string s)
    {
        currentAttempt = currentAttempt - 1; //segment for is input has allowed words but not answer
        return false; //temp holder
    }

    public void UpdateCells(int column, int row)
    {
        if (grid[column, row] == 0)
        {
            grid[column, row] = currentAttempt;
        }

        //FindObjectOfType<Controller>().SubmitGuess(column, row);


    }
}
