using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightButtons : MonoBehaviour
{
    public GameObject HL_Action;
    public GameObject HL_Select;
    public GameObject HL_BackArrow;
    public GameObject HL_SpawnShape;
    public GameObject HL_RotateShape;
    public GameObject HL_MoveShape;
    public GameObject HL_ScaleShape;
    public GameObject HL_ColorShape;
    public GameObject HL_X;
    public GameObject HL_Y;
    public GameObject HL_Z;
    public GameObject HL_XYZ;
    public GameObject HL_TaskFinished;
    

    // Start is called before the first frame update
    void Start()
    {
        HL_Action.SetActive(false);
        HL_Select.SetActive(false);
        HL_BackArrow.SetActive(false);
        HL_SpawnShape.SetActive(false);
        HL_RotateShape.SetActive(false);
        HL_MoveShape.SetActive(false);
        HL_ScaleShape.SetActive(false);
        HL_ColorShape.SetActive(false);
        HL_X.SetActive(false);
        HL_Y.SetActive(false);
        HL_Z.SetActive(false);
        HL_XYZ.SetActive(false);
        HL_TaskFinished.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clear()
    {
        HL_Action.SetActive(false);
        HL_Select.SetActive(false);
        HL_BackArrow.SetActive(false);
        HL_SpawnShape.SetActive(false);
        HL_RotateShape.SetActive(false);
        HL_MoveShape.SetActive(false);
        HL_ScaleShape.SetActive(false);
        HL_ColorShape.SetActive(false);
        HL_X.SetActive(false);
        HL_Y.SetActive(false);
        HL_Z.SetActive(false);
        HL_XYZ.SetActive(false);
        HL_TaskFinished.SetActive(false);
    }
     
}
