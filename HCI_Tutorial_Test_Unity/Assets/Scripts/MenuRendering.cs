using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuRendering : MonoBehaviour
{
    public GameObject BasicMenu;
    public GameObject ActionMenu;
    public GameObject RotateMenu;
    public GameObject PositionMenu;
    public GameObject ScaleMenu;
    public GameObject ColorMenu;

    public GameObject ActiveMenu;
    // Start is called before the first frame update
    void Start()
    {
        ActiveMenu = BasicMenu;
        BasicMenu.SetActive(true);
        ActionMenu.SetActive(false);
        RotateMenu.SetActive(false);
        PositionMenu.SetActive(false);
        ScaleMenu.SetActive(false);
        ColorMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OpenActionMenu()
    {
        BasicMenu.SetActive(false);
        ActionMenu.SetActive(true);
        ActiveMenu = ActionMenu;
    }

    public void OpenRotateMenu()
    {
        ActionMenu.SetActive(false);
        RotateMenu.SetActive(true);
        ActiveMenu = RotateMenu;
    }

    public void OpenPositionMenu()
    {
        ActionMenu.SetActive(false);
        PositionMenu.SetActive(true);
        ActiveMenu = PositionMenu;
    }

    public void OpenScaleMenu()
    {
        ActionMenu.SetActive(false);
        ScaleMenu.SetActive(true);
        ActiveMenu = ScaleMenu;
    }
    public void OpenColorMenu() { 
        ActionMenu.SetActive(false);
        ColorMenu.SetActive(true);
        ActiveMenu = ColorMenu;
    }

    public void GoBack()
    {
        if (ActiveMenu == ActionMenu)
        {
            ActionMenu.SetActive(false);
            BasicMenu.SetActive(true);
            ActiveMenu = BasicMenu;
        }
        if (ActiveMenu == RotateMenu)
        {
            RotateMenu.SetActive(false);
            ActionMenu.SetActive(true);
            ActiveMenu = ActionMenu;
        }
        if (ActiveMenu == PositionMenu)
        {
            PositionMenu.SetActive(false);
            ActionMenu.SetActive(true);
            ActiveMenu = ActionMenu;
        }
        if (ActiveMenu == ScaleMenu)
        {
            ScaleMenu.SetActive(false);
            ActionMenu.SetActive(true);
            ActiveMenu = ActionMenu;
        }
        if (ActiveMenu == ColorMenu)
        {
            ColorMenu.SetActive(false);
            ActionMenu.SetActive(true);
            ActiveMenu = ActionMenu;
        }
    }
}
