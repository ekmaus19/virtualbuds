using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoToMedRoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
         SceneManager.LoadScene("SpaceRoom", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
