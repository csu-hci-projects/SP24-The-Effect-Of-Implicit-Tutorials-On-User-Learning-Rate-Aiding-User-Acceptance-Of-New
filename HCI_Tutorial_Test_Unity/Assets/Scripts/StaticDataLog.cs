using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticDataLog : MonoBehaviour
{
    static private bool highlightOn = false;
    public void setHighlightTrue(){
        highlightOn = true;
    }
    public bool getHighlightOn(){
        return highlightOn;
    }

}
