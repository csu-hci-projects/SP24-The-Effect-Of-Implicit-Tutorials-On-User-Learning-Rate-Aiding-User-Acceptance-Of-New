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
    public GameObject SpawnMenu;
    public GameObject PopupMenu;

    public GameObject ActiveMenu;
    // Start is called before the first frame update
    void Start()
    {
        ActiveMenu = PopupMenu;
        PopupMenu.SetActive(true);
        BasicMenu.SetActive(false);
        ActionMenu.SetActive(false);
        RotateMenu.SetActive(false);
        PositionMenu.SetActive(false);
        ScaleMenu.SetActive(false);
        ColorMenu.SetActive(false);
        SpawnMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenBasicMenu()
    {
        PopupMenu.SetActive(false);
        BasicMenu.SetActive(true);
        ActiveMenu = BasicMenu;
        FindObjectOfType<HighlightButtons>().BasicMenuHL();
    }

    public void OpenActionMenu()
    {
        BasicMenu.SetActive(false);
        ActionMenu.SetActive(true);
        ActiveMenu = ActionMenu;
        FindObjectOfType<HighlightButtons>().ActionMenuHL();

    }

    public void OpenRotateMenu()
    {
        ActionMenu.SetActive(false);
        RotateMenu.SetActive(true);
        ActiveMenu = RotateMenu;
        FindObjectOfType<HighlightButtons>().RotateMenuHL();
    }

    public void OpenPositionMenu()
    {
        ActionMenu.SetActive(false);
        PositionMenu.SetActive(true);
        ActiveMenu = PositionMenu;
        FindObjectOfType<HighlightButtons>().MoveMenuHL();
    }

    public void OpenScaleMenu()
    {
        ActionMenu.SetActive(false);
        ScaleMenu.SetActive(true);
        ActiveMenu = ScaleMenu;
        FindObjectOfType<HighlightButtons>().ScaleMenuHL();
    }

    public void OpenColorMenu() { 
        ActionMenu.SetActive(false);
        ColorMenu.SetActive(true);
        ActiveMenu = ColorMenu;
        FindObjectOfType<HighlightButtons>().ColorMenuHL();
    }

    public void OpenSpawnMenu() {
        ActionMenu.SetActive(false);
        SpawnMenu.SetActive(true);
        ActiveMenu = SpawnMenu;
        FindObjectOfType<HighlightButtons>().SpawnMenuHL();
    }

    public void OpenPopupMenu(){
        PopupMenu.SetActive(true);
        BasicMenu.SetActive(false);
        ActiveMenu = PopupMenu;
        FindObjectOfType<HighlightButtons>().Clear();
    }

    public void GoBack()
    {
        if (ActiveMenu == ActionMenu)
        {
            ActionMenu.SetActive(false);
            BasicMenu.SetActive(true);
            ActiveMenu = BasicMenu;
            FindObjectOfType<HighlightButtons>().BasicMenuHL();
        }
        if (ActiveMenu == RotateMenu)
        {
            RotateMenu.SetActive(false);
            ActionMenu.SetActive(true);
            ActiveMenu = ActionMenu;
            FindObjectOfType<HighlightButtons>().ActionMenuHL();
        }
        if (ActiveMenu == PositionMenu)
        {
            PositionMenu.SetActive(false);
            ActionMenu.SetActive(true);
            ActiveMenu = ActionMenu;
            FindObjectOfType<HighlightButtons>().ActionMenuHL();
        }
        if (ActiveMenu == ScaleMenu)
        {
            ScaleMenu.SetActive(false);
            ActionMenu.SetActive(true);
            ActiveMenu = ActionMenu;
            FindObjectOfType<HighlightButtons>().ActionMenuHL();
        }
        if (ActiveMenu == ColorMenu)
        {
            ColorMenu.SetActive(false);
            ActionMenu.SetActive(true);
            ActiveMenu = ActionMenu;
            FindObjectOfType<HighlightButtons>().ActionMenuHL();
        }
        if (ActiveMenu == SpawnMenu)
        {
            SpawnMenu.SetActive(false);
            ActionMenu.SetActive(true);
            ActiveMenu = ActionMenu;
            FindObjectOfType<HighlightButtons>().ActionMenuHL();
        }
    }
}
