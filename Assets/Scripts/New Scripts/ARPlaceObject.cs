using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


[RequireComponent(typeof(ARRaycastManager))]
public class ARPlaceObject : MonoBehaviour
{

    //  public GameObject gameObjectToInstantiate;
    public GameObject[] Models;
    public GameObject Parent;

    private GameObject spawnedObject;
    private ARRaycastManager raycastManager;
    private Vector2 touchPosition;

    private ShowObjects2 SelectedGameObject;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;
        return false;
    }

    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPosition))
            return;
        if (raycastManager.Raycast(touchPosition,hits,TrackableType.PlaneWithinPolygon))
        {
            var hitPose = hits[0].pose;

            spawnedObject.transform.position = hitPose.position;
            spawnedObject.transform.rotation = hitPose.rotation;
            //if (spawnedObject == null)
            //{
            //    // spawnedObject = Instantiate(gameObjectToInstantiate, hitPose.position, hitPose.rotation);
            //}
            //else
            //{
            //    spawnedObject.transform.position = hitPose.position;
            //}
        }
    }

    public void DisplayObjectinARMood()
    {
        //this function for the ARMood
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
                    InstantiateObjectinARMood(Models[0]);
                    break;
                case "Brain":
                    InstantiateObjectinARMood(Models[1]);
                    break;
                case "Lungs":
                    InstantiateObjectinARMood(Models[2]);
                    break;
                case "Eyes":
                    InstantiateObjectinARMood(Models[3]);
                    break;
                default:
                    break;
            }
        }
    }

    void InstantiateObjectinARMood(GameObject obj)
    {
        Debug.Log("in the second function");
        spawnedObject = Instantiate(obj);
        spawnedObject.transform.parent = Parent.transform;
    }



}
