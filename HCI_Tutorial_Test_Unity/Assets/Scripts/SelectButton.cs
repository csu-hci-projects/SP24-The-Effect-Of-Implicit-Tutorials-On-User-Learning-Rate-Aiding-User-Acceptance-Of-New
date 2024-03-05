using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectButton : MonoBehaviour
{
    public bool selectorOn = false;
    // Start is called before the first frame update
    public void SelectingButton()
    {
        selectorOn = !selectorOn;
        //UnityEngine.Debug.Log(selectorOn);
    }
}
