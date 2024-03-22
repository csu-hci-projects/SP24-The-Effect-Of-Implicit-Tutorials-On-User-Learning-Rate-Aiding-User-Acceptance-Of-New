using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public Material[] colors;
    private GameObject selector;
    private GameObject selected;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        selector = GameObject.Find("Selected");
        //button = gameObject.GetComponent<Button>();
        //button.onClick.AddListener(Click);
    }
    public void ColorSetter(int index){
        selected = selector.GetComponent<ObjectSelection>().getSelected();
        if (selected != null)
        {
            selected.GetComponent<Renderer>().material = colors[index];
                //.SetColor("_Color", new Color(.5f, .5f, .1f));
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
