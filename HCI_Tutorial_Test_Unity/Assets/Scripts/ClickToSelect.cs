using System.Diagnostics;
using UnityEngine;

public class ClickToSelect : MonoBehaviour
{

    private GameObject selector;
    private SelectButton selectButton;

    void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
        selector = GameObject.Find("Selected");
        selectButton = GameObject.FindObjectOfType<SelectButton>(true);
    }
    void OnMouseDown(){
        if (selectButton.selectorOn)
        {
            //UnityEngine.Debug.Log("selecting");
            selector.GetComponent<ObjectSelection>().setSelected(gameObject);
            selectButton.selectorOn = false;
        }
    }
}
