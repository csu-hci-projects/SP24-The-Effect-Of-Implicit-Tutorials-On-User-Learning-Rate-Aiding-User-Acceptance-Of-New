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
            taskDescText.SetText("");
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
        string task = "\nCreate a long, thin, orange cylinder.";
        return task;
    }
    string TaskOneThr(){
        string task = "\nCreate a yellow pyramid and position all three objects to make the appearance of a pencil.";
        return task;
    }

    string TaskTwoOne(){
        string task = "\nCreate two blue spheres that do not overlap or intersect.";
        return task;
    }
    string TaskTwoTwo(){
        string task = "\nCreate three long, thin, purple rectangular prisms and position them so the two spheres connect all shapes in a line.";
        return task;
    }

    string TaskTwoThr(){
        string task = "\nFlatten the spheres and rotate the prisms to make the appearance of glasses. Shapes may overlap some.";
        return task;
    }

    string TaskThrOne(){
        string task = "Build a simple house with a roof, a chimney, and a door. Each shape used must be a differnt color.";
        return task;
    }
 
    void purgeObjects(){
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag("SpawnedObject");
        foreach(GameObject ob in objectsToDestroy){
            Destroy(ob);
        }
    }
}
