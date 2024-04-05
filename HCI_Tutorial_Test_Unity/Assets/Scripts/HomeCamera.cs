using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeCamera : MonoBehaviour
{
    public GameObject cameraObject;
    private Button button;
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(Click);
    }


    void Click()
    {
        cameraObject.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
