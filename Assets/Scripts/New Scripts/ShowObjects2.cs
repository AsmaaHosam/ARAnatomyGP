using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ShowObjects2 : MonoBehaviour
{
    public GameObject Parent;
    public GameObject Heart;
    public GameObject Brain;
    public GameObject Lungs;
    public GameObject Eye;

  
   

    public void DisplayObjectin3DMood()
    {
        //this function for the 3DMood
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        if (Parent.transform.childCount > 0)
        {
            for (int i = 0; i < Parent.transform.childCount; i++)
            {
                Parent.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
        if (Parent.transform.Find(btnName + "(Clone)")) 
        {
            Parent.transform.Find(btnName + "(Clone)").gameObject.SetActive(true);
        }

        else 
        {
            switch (btnName)
            {
                case "Heart":
                    InstantiateObject(Heart);
                    break;
                case "Brain":
                    InstantiateObject(Brain);
                    break;
                case "Lungs":
                    InstantiateObject(Lungs);
                    break;
                case "Eyes":
                    InstantiateObject(Eye);
                    break;
                default:
                    break;
            }
        }
    }

    void InstantiateObject(GameObject obj)
    {
        GameObject child;
        child = Instantiate(obj);
        child.transform.position = Parent.transform.position;
        child.transform.parent = Parent.transform;
    }

   
}
