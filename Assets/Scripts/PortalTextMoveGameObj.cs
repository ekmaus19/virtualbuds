using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextMoveGameObj : MonoBehaviour
{
    public GameObject text;
    public Transform player;


    public float speed;

    public void Update()
    {
        float y = Mathf.PingPong(Time.time * speed, 1) +2;
        text.transform.localPosition = new Vector3(text.transform.localPosition.x, (y/2)+1, text.transform.localPosition.z);
        text.transform.LookAt(player);
        // text.transform.localPosition = new Vector3(this.gameObject.transform.localPosition.x, (y/2)+1, this.gameObject.transform.localPosition.z);
    }
}
