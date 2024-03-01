using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CellVisual : MonoBehaviour
{
    [SerializeField] public int row = 0;
    [SerializeField] public int col = 0;
    [SerializeField] TMP_Text letterText;

    public void ChangeColor()
    {
        FindObjectOfType<Controller>().SubmitGuess(col, row);
    }

    public void UpdateLetter(char letter)
    {
        letterText.text = letter.ToString();
    }
}


/*
 * Space for letter (char type) and Color (color type)
 */