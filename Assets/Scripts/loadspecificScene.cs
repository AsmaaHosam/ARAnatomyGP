using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadspecificScene : MonoBehaviour
{

    public void loadScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
