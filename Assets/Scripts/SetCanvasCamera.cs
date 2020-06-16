using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCanvasCamera : MonoBehaviour
{

    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas = this.gameObject.GetComponent<Canvas>();
        canvas.worldCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
