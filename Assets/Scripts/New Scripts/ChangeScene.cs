using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MoveToARMood()
    {
        SceneManager.LoadScene(5);
    }

    public void MoveTo3DMood()
    {
        SceneManager.LoadScene(4);
    }
}
