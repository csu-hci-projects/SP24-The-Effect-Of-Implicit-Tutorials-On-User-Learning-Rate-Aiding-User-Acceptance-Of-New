
using UnityEngine;
using UnityEngine.UI;

public abstract class TransformButton : MonoBehaviour
{
    // Start is called before the first frame update
    protected Button button;
    public GameObject transformer;
    public GameObject selector;
    void Start()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(Click);
    }
    void  Click(){
        SetType();
        if(selector.GetComponent<ObjectSelection>().getSelected() != null){
            transformer.SetActive(true);
        }
    }
    protected abstract void SetType();

}
