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

    public bool SettingsPage = false;


    public void FileWrite(string s)
    {
        string data = "";
        if (File.Exists(fileName))
        {
            var sreader = File.OpenText(fileName);
            var line = sreader.ReadLine();
            while (line != null)
            {
                data += line + "\n";
                line = sreader.ReadLine();
            }
            sreader.Close();
        }
        UnityEngine.Debug.Log("file writing to " + fileName);
        var swriter = File.CreateText(fileName);
        swriter.WriteLine(data);
        swriter.WriteLine(s);
        swriter.Close();
    }

    public void SaveSettings()
    {
        var sr = File.CreateText(Application.persistentDataPath + "/TrialSettings/" + "TrialSettings.txt");
        sr.WriteLine(fileName);
        sr.Close();
    }

    public void OpenSettings()
    {
        if (File.Exists(Application.persistentDataPath + "/TrialSettings/" + "TrialSettings.txt"))
        {
            var sr = File.OpenText(Application.persistentDataPath + "/TrialSettings/" + "TrialSettings.txt");
            var line = sr.ReadLine();
            if (line != null)
            {
                fileName = line;
            }
        }
        else
        {
            UnityEngine.Debug.Log("Could not Open the file: " + Application.persistentDataPath + "/TrialSettings/" + "TrialSettings.txt" + " for reading.");
            return;
        }
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
        fileName = Application.persistentDataPath + "/UserData/" + UserID + "_" + TrialType + "_" + ".txt";
        UnityEngine.Debug.Log(fileName);
    }

    public void UpdateUserID()
    {
        UserID = UserID_field.text;
    }

    public void UpdateTrialType()
    {
        TrialType = TrialType_field.text;
    }


    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log(Application.persistentDataPath);
        if (!SettingsPage) { OpenSettings(); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
