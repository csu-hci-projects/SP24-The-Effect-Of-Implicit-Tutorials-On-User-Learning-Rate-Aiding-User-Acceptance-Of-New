using RuntimeHandle;
using UnityEngine;

public class ObjectSelection : MonoBehaviour
{

    private GameObject selectedObject;
    public GameObject transformer;

    public void setSelected(GameObject newSelectedObject){
        if(selectedObject != null){
            selectedObject.GetComponent<Outline>().enabled = false;
        }
            selectedObject = newSelectedObject;
            selectedObject.GetComponent<Outline>().enabled = true;
            transformer.GetComponent<RuntimeTransformHandle>().target = selectedObject.GetComponent<Transform>();
    }
    public GameObject getSelected(){
        return selectedObject;
    }
    public void deSelect(){
        if (selectedObject != null){
            selectedObject.GetComponent<Outline>().enabled = false;
            selectedObject = null;
            transformer.SetActive(false);
        }
    }
}
