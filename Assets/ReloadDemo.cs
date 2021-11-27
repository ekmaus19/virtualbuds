using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReloadDemo : MonoBehaviour
{
    public void ReloadMainScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
