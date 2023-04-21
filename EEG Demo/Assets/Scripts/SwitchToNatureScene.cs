using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToNatureScene : MonoBehaviour
{
    public void NatureScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void Return(string name)
    {
        SceneManager.LoadScene(name);
    }
}
