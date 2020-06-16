using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject[] models;
  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //info.transform.LookAt(Camera.main.transform);
        //info.transform.rotation = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);
    }

    public void ActivateSelectedModel(int modelIndex)
    {
        for(int i=0;i<models.Length;i++)
        {
            models[i].SetActive(false);
        }
        models[modelIndex].SetActive(true);
        Debug.Log("switch");
    }

    public void displayInfo()
    {
        for (int i = 0; i < models.Length; i++)
        {
            if(models[i].activeInHierarchy==true)
            {
                GameObject info = models[i].transform.Find("Info").gameObject;
                info.SetActive(true);

            }
        }
    }
}
