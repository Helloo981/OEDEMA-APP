using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using System.Linq; //to use lists

public class ReadInputQOL : MonoBehaviour
{
    private string input;  //text user input
    public TMP_InputField userInput;  //text field
    public TMP_Dropdown userDropdown;

    public Transform contentWindow;
    public TextMeshProUGUI recallTextObject;


    public void getDiary()
    {
        string readFromFile = Application.dataPath + "/Log.txt";

        List<string> fileLines = File.ReadAllLines(readFromFile).ToList();

        foreach (string line in fileLines)
        {
            Instantiate(recallTextObject, contentWindow);
            recallTextObject.text = line + "\n";
        }
    }



    public void AddUserInput(string text)
    {
        text = userInput.text;
        //need a path for where file is created
        string path = Application.dataPath + "/Log.txt"; //creates in assets folder

        //create file if doens't exist
        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Quality of Life Diary \n\n");
        }

        //add system date to diary
        string content = "Log Date: " + System.DateTime.Now + "\n";
        File.AppendAllText(path, content);
        //add dropdown choice to diary
        File.AppendAllText(path, userDropdown.options[userDropdown.value].text);
        File.AppendAllText(path, "\n");
        File.AppendAllText(path, text); //add text input field from user to diary
        File.AppendAllText(path, "\n\n");
        userInput.text = ""; //resets user input box to placeholder text

    }
}   
