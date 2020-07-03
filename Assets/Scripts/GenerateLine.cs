using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLine : MonoBehaviour
{

    public LineRenderer line;
    public GameObject start;
    public GameObject end;
    // Start is called before the first frame update
    void Start()
    {
        line.SetWidth(0.01f,0.05f);
        line.SetVertexCount(2);
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, start.transform.position);
        line.SetPosition(1, end.transform.position);
    }
}
