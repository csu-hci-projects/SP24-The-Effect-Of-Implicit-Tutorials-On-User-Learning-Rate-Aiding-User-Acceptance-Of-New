using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickCounter : MonoBehaviour
{
    public ArrayList buttonRecord = new ArrayList();

    public void addButton(string buttonName, float time){
        (string, float) record = (buttonName, time);
        buttonRecord.Add(record);
        printList();
    }
    void printList(){
        string recordString = "Record:   ";
        foreach ((string, float) record in buttonRecord){
            recordString += record.Item1 + ": " + record.Item2 + ", ";
        }
        Debug.Log(recordString);
    }
}
