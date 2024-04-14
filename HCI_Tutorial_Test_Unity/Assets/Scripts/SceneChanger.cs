using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    /*
     noTutorial = notut
     standardTutorial = stut
     highlightTutorial = htut
     
     */
    private StaticDataLog sdl;
    public int NextSceneIndex = 0;
    public DataFileWriter dfw;

    void Start(){
        sdl = GameObject.Find("StaticHighlight").GetComponent<StaticDataLog>();
    }

    public void SwitchScenes()
    {
        SceneManager.LoadScene(NextSceneIndex);
    }

    public void SwitchScenesInitially()
    {
        string TrialType = dfw.TrialType;
        if (TrialType == "notut")
        {
            //send to first trial for no tutorial
            SceneManager.LoadScene(NextSceneIndex); //temp
        }
        else if (TrialType == "stut")
        {
            //send to first trial for standard tutorial
            SceneManager.LoadScene(NextSceneIndex); //temp
        }
        else if (TrialType == "htut")
        {
            //send to first trial for highlighted tutorial
            SceneManager.LoadScene(NextSceneIndex);
            sdl.setHighlightTrue();
        }
        else
        {
            SceneManager.LoadScene(NextSceneIndex);
        }
    }
}
