using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskFinishedButton : MonoBehaviour
{
    private Button button;
    private GameObject dataManager;
    private DataFileWriter fileWriter;
    void Start()
    {
        dataManager = GameObject.Find("DataManager");
        fileWriter = dataManager.GetComponent<DataFileWriter>();
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(Click);
    }

    void Click()
    {
        dataManager.GetComponent<ClickCounter>().addButton(gameObject.name, Time.time);
        string outputString = dataManager.GetComponent<ClickCounter>().printList();
        fileWriter.FileWrite(outputString);
    }
}
