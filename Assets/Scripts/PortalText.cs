using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PortalText : MonoBehaviour
{
    //public TMP_Text textUse;
   // [SerializeField] private Text textUse;
    //[SerializeField] private Image textUse;
    [SerializeField] private GameObject portalPlace;
    public GameObject textUse;
    private Vector3 offset;
    private Vector3 locationNow;
    private Vector3 screenPosition;
    public float speed;

    // Start is called before the first frame update
    /// <summary>
    ///  USE ONLY IF THE TEXT IS a TEXTMESH OBJECT,,,,NOT a GAME OBJECT!!!
    /// </summary>
    void Start()
    {
        ///    Debug.Log(textUse.text);
        offset = new Vector3(0,150,0);
        screenPosition = Camera.current.WorldToScreenPoint(portalPlace.transform.position);
        textUse.gameObject.SetActive(false);
    }

    void enableDisplay(bool on) {
        if (on) {
            textUse.gameObject.SetActive(true);
            // locationNow = screenPosition + offset;
            // textUse.transform.position = screenPosition;
        } else
        {
            textUse.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        screenPosition = Camera.current.WorldToScreenPoint(portalPlace.transform.position);
        Debug.Log(screenPosition.z);
        //Debug.Log(screenPosition);
        if (screenPosition.z < 0f)  //Disable display when behind the camera
        {
            enableDisplay(false);
        }
        else
        {
            enableDisplay(true);
            //float y = mathf.pingpong(time.time * speed, 1) * 6 - 3;
            //vector3 pos = textuse.transform.position;
            //pos.y = y;
        }

        
    }
}
