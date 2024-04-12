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
    public GameObject HL_TaskFinished;

    public GameObject HL_X_R; //R for rotate
    public GameObject HL_Y_R;
    public GameObject HL_Z_R;
    public GameObject HL_XYZ_R;
    public GameObject HL_X_M; //M for move (position)
    public GameObject HL_Y_M;
    public GameObject HL_Z_M;
    public GameObject HL_XYZ_M;
    public GameObject HL_X_S; //S for scale
    public GameObject HL_Y_S;
    public GameObject HL_Z_S;
    public GameObject HL_XYZ_S;

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
        HL_TaskFinished.SetActive(false);

        HL_X_R.SetActive(false); //R for rotate
        HL_Y_R.SetActive(false);
        HL_Z_R.SetActive(false);
        HL_XYZ_R.SetActive(false);
        HL_X_M.SetActive(false); //M for move(position)
        HL_Y_M.SetActive(false);
        HL_Z_M.SetActive(false);
        HL_XYZ_M.SetActive(false);
        HL_X_S.SetActive(false); //S for scale
        HL_Y_S.SetActive(false);
        HL_Z_S.SetActive(false);
        HL_XYZ_S.SetActive(false);
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
        HL_TaskFinished.SetActive(false);

        HL_X_R.SetActive(false); //R for rotate
        HL_Y_R.SetActive(false);
        HL_Z_R.SetActive(false);
        HL_XYZ_R.SetActive(false);
        HL_X_M.SetActive(false); //M for move(position)
        HL_Y_M.SetActive(false);
        HL_Z_M.SetActive(false);
        HL_XYZ_M.SetActive(false);
        HL_X_S.SetActive(false); //S for scale
        HL_Y_S.SetActive(false);
        HL_Z_S.SetActive(false);
        HL_XYZ_S.SetActive(false);
    }
     
    public void BasicMenuHL()
    {
        Clear();
        HL_Action.SetActive(true);
        HL_Select.SetActive(true);
    }

    public void RotateMenuHL()
    {
        Clear();
        HL_X_R.SetActive(true);
        HL_Y_R.SetActive(true);
        HL_Z_R.SetActive(true);
        HL_XYZ_R.SetActive(true);
        HL_BackArrow.SetActive(true);
    }

    public void MoveMenuHL()
    {
        Clear();
        HL_X_M.SetActive(true);
        HL_Y_M.SetActive(true);
        HL_Z_M.SetActive(true);
        HL_XYZ_M.SetActive(true);
        HL_BackArrow.SetActive(true);
    }

    public void ScaleMenuHL()
    {
        Clear();
        HL_X_S.SetActive(true);
        HL_Y_S.SetActive(true);
        HL_Z_S.SetActive(true);
        HL_XYZ_S.SetActive(true);
        HL_BackArrow.SetActive(true);
    }
}
