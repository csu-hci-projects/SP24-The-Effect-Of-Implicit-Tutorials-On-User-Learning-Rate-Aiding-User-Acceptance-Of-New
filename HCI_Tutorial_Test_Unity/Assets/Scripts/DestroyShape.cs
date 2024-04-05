using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyShape : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject selector;
    private Button button;
    public GameObject transformer;
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(Click);
    }

    // Update is called once per frame
    void Click()
    {
        transformer.SetActive(false);
        Destroy(selector.GetComponent<ObjectSelection>().getSelected());
    }
}
