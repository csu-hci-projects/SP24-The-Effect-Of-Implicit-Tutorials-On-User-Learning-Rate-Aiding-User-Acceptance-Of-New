using System.Diagnostics;
using UnityEngine;

public class ClickToSelect : MonoBehaviour
{

    private GameObject selector;
    public SelectButton selectButton;

    void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
        selector = GameObject.Find("Selected");
    }
    void OnMouseDown(){
        if (selectButton.selectorOn)
        {
            //UnityEngine.Debug.Log("selecting");
            selector.GetComponent<ObjectSelection>().setSelected(gameObject);
        }
    }
}
