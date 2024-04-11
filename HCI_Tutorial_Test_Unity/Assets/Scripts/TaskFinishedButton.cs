using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TaskFinishedButton : MonoBehaviour
{
    private Button button;
    private GameObject dataManager;
    private DataFileWriter fileWriter;
    public GameObject taskLabel;
    public GameObject taskDesc;
    private TextMeshProUGUI taskLabelText;
    private TextMeshProUGUI taskDescText;
    void Start()
    {
        dataManager = GameObject.Find("DataManager");
        taskLabelText = taskLabel.GetComponent<TextMeshProUGUI>();
        taskDescText = taskDesc.GetComponent<TextMeshProUGUI>();
        fileWriter = dataManager.GetComponent<DataFileWriter>();
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(Click);
    }

    void Click()
    {
        dataManager.GetComponent<ClickCounter>().addButton(gameObject.name, Time.time);
        string outputString = dataManager.GetComponent<ClickCounter>().printList();
        fileWriter.FileWrite(outputString);
        UpdatePopup();
    }
    void UpdatePopup(){
        int currentTrial = fileWriter.TrialNumber;
        int currentRound = fileWriter.TrialRound;
        if(currentTrial == 3){
            currentTrial = 1;
            currentRound += 1;
            purgeObjects();
        }
        else{
            currentTrial += 1;
        }
        fileWriter.TrialNumber = currentTrial;
        fileWriter.TrialRound = currentRound;
        if(currentRound >= 3 && currentTrial >= 2){
            taskLabelText.SetText("Finished");
        }
        else{
            string newTaskLabel = string.Format("Task {0}.{1}", currentRound, currentTrial);
            taskLabelText.SetText(newTaskLabel);
            string newTask = TaskSelection(currentRound, currentTrial);
            taskDescText.SetText(newTask);
        }
    }

    string TaskSelection(int round, int trial){
        if(round == 1){
            if (trial == 2){
                return TaskOneTwo();
            }
            if (trial == 3){
                return TaskOneThr();
            }
        }
        if(round == 2){
            if (trial == 1){
                return TaskTwoOne();
            }
            if(trial == 2){
                return TaskTwoTwo();
            }
            if(trial == 3){
                return TaskTwoThr();
            }
        }
        return TaskThrOne();
    }

    string TaskOneTwo(){
        string task = "1. This is first\n2. This is next";
        return task;
    }
    string TaskOneThr(){
        string task = "1. TaskOneThr\n2. TaskOneThr";
        return task;
    }

    string TaskTwoOne(){
        string task = "1. TaskTwoOne\n2. TaskTwoOne";
        return task;
    }
    string TaskTwoTwo(){
        string task = "1. TaskTwoTwo\n2. TaskTwoTwo";
        return task;
    }

    string TaskTwoThr(){
        string task = "1. TaskTwoThr\n2. TaskTwoThr";
        return task;
    }

    string TaskThrOne(){
        string task = "Final Task Lets Go";
        return task;
    }
 
    void purgeObjects(){
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag("SpawnedObject");
        foreach(GameObject ob in objectsToDestroy){
            Destroy(ob);
        }
    }
}
