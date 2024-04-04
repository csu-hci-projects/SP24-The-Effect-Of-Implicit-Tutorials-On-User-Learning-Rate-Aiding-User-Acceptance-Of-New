using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButton : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Cube2;
    public GameObject Cube3;
    public GameObject Sphere;
    public GameObject Cylinder;
    public GameObject Pyramid;


    // Start is called before the first frame update
    void Start()
    {
        Cube.SetActive(false);
        Cube2.SetActive(false);
        Cube3.SetActive(false);
        Sphere.SetActive(false);
        Cylinder.SetActive(false);
        Pyramid.SetActive(false);
    }

    
    // Update is called once per frame
     
}
