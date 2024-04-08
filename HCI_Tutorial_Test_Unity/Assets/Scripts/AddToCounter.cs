using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToCounter : MonoBehaviour
{
    private GameObject dataManager;
    private Button button;

    void Start()
    {
        dataManager = GameObject.Find("DataManager");
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(countClick);
    }

    void countClick(){
        dataManager.GetComponent<ClickCounter>().addButton(gameObject.name, Time.time);
    }


}
