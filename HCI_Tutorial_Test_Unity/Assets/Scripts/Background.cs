using Unity.VisualScripting;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject selector;

    void Update(){
        // if(Input.GetKeyDown(KeyCode.Mouse0)){
        //     RaycastHit hit = new RaycastHit();        
        //     Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

        //      if (Physics.Raycast(ray, out hit))
        //      {
        //          if(hit.collider.gameObject == gameObject){
        //             selector.GetComponent<ObjectSelection>().deSelect();
        //          }
        //      } 
        // }
    }
    void OnMouseDown(){
        selector.GetComponent<ObjectSelection>().deSelect();
    }
   
}
