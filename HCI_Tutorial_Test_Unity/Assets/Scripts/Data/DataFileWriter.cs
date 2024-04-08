using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Diagnostics;
using TMPro;


public class DataFileWriter : MonoBehaviour
{
    public TMP_InputField UserID_field;
    public TMP_InputField TrialType_field;
    public string fileName = "";
    public string UserID = "";
    public int TrialNumber = 1;
    public string TrialType = "";


    public void WriteString()
    {
        if (File.Exists(fileName))
        {
            UnityEngine.Debug.Log(fileName + " already exists.");
            return;
        }
        var sr = File.CreateText(fileName);
        sr.WriteLine("Insert Data Here");
        UnityEngine.Debug.Log("Writing");
        sr.Close();
    }

    public void ReadFile()
    {
        if (File.Exists(fileName))
        {
            var sr = File.OpenText(fileName);
            var line = sr.ReadLine();
            while (line != null)
            {
                UnityEngine.Debug.Log(line); // prints each line of the file
                line = sr.ReadLine();
            }
        }
        else
        {
            UnityEngine.Debug.Log("Could not Open the file: " + fileName + " for reading.");
            return;
        }
    }




    public void UpdateFilename()
    {
        fileName = Application.persistentDataPath + "\\UserData\\" + UserID + "_" + TrialType + "_" + TrialNumber.ToString() + ".txt";
        UnityEngine.Debug.Log(fileName);
    }

    public void UpdateUserID()
    {
        UserID = UserID_field.text;
    }

    public void UpdateTrialNumber(int change)
    {
        if (change == 0)
        {
            TrialNumber = 1;
        }
        else
        {
            TrialNumber += change;
        }
    }

    public void UpdateTrialType()
    {
        TrialType = TrialType_field.text;
    }


    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log(Application.persistentDataPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
