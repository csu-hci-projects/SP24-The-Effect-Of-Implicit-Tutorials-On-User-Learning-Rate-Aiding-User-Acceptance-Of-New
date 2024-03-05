using UnityEngine;

public class ClickToSelect : MonoBehaviour
{

    private GameObject selector;
    void Start()
    {
        gameObject.GetComponent<Outline>().enabled = false;
        selector = GameObject.Find("Selected");
    }
    void OnMouseDown(){
        selector.GetComponent<ObjectSelection>().setSelected(gameObject);
    }
}
