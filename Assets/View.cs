using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class View : MonoBehaviour
{
    [SerializeField] Transform[] rows;
    [SerializeField] Color green;
    [SerializeField] Color yellow;
    [SerializeField] Color red;
    public void Setup()
    {
        for (int r = 0; r < 6; r++)
        {
            for (int c = 0; c < 5; c++)
            {
                rows[r].GetChild(c).GetComponent<CellVisual>().UpdateLetter(' '); //Changes button text to just a blank whitepsace
            }
        }
    }

    public void UpdateView(int column, int row, char w)
    {
        if (w ==  ' ')
        {
            // Space for having input array to display on screen
        }
        
        
        
    }
}

//leftover or possible use for code

/*for (int r = 0; r < 6; r++)
{
    for (int c = 0; c < 5; c++)
    {
        //rows[r].GetChild(c).GetComponent<CellVisual>().UpdateLetter(m.grid[c, r].ToString()[0]); //Changes buttons to letters

    }
}*/
//char letter = GetComponent<Controller>().SubmitGuess();

//rows[row].GetChild(column).GetComponent<CellVisual>().UpdateLetter(letter); int column, int row, int word