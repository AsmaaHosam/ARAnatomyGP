using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayModel : MonoBehaviour
{

    public GameObject Model;
    private GameObject model;
    // Start is called before the first frame update
    void Start()
    { 
        model = Instantiate(Model, new Vector3(0, 0, 33), Camera.main.transform.rotation);
        model.transform.LookAt(Camera.main.transform);
        //model.transform.rotation = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0)


    }

   
}
