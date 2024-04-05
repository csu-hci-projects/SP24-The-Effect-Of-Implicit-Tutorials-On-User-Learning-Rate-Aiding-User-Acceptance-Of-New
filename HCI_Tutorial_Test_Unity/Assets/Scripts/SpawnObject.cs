using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpawnObject : MonoBehaviour
{
    public GameObject shape;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(Click);
    }


    void Click()
    {
        Instantiate(shape, new Vector3(0,0,0), Quaternion.identity);
    }
}
