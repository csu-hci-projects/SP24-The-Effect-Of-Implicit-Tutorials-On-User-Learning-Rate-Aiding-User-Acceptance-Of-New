using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToCounter : MonoBehaviour
{
    private GameObject clickCounter;
    private Button button;

    void Start()
    {
        clickCounter = GameObject.Find("ClickInformation");
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(countClick);
    }

    void countClick(){
        clickCounter.GetComponent<ClickCounter>().addButton(gameObject.name, Time.time);
    }


}
