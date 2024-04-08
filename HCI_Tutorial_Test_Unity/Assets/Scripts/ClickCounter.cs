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
    }
    public string printList(){
        string recordString = "";
        foreach ((string, float) record in buttonRecord){
            recordString += record.Item1 + "," + record.Item2 + "\n";
        }
        return recordString;
    }
}
