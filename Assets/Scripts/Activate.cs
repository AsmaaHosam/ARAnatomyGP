using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject[] models;
  
    public void ActivateSelectedModel(int index)
    {
        if (index < 0 || index >= models.Length)
        {
            Debug.LogError("index of the selected item is out of range!");
            return;
        }

        foreach (var model in models)
            model.SetActive(false);

        models[index].SetActive(true);

    }


    public void ActivateSelectedModelOnRunTime(int index)
    {
       
        if (GameObject.Find("PlacedObject(Clone)"))
        {
            GameObject _models = GameObject.Find("PlacedObject(Clone)");
            GameObject[] Ch_models = new GameObject[3];

            for (int i = 0; i < Ch_models.Length; i++)
            {
                Ch_models[i] = _models.transform.GetChild(i).gameObject;
                Debug.Log("All children found");
            }

            foreach (var model in Ch_models)
                model.SetActive(false);

            Ch_models[index].SetActive(true);
        }
        ActivateSelectedModel(index);
    }


    public void displayInfo()
    {
        for (int i = 0; i < models.Length; i++)
        {
            if(models[i].activeInHierarchy==true)
            {
                GameObject info = models[i].transform.Find("Info").gameObject;
                if (info == null)
                    Debug.Log("Null");
                else
                info.SetActive(true);

            }
        }
    }
}
