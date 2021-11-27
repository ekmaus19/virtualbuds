using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToRoomVR : OVRScreenFade
{
    [SerializeField] private GameObject thePlayer;
    private Vector3 playerPosition;

    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("EnterTherapyRoom")) {
            playerPosition = new Vector3(10.81f, 3f, -12f);
        } else if (this.CompareTag("EnterWaitingRoom")){
            playerPosition = new Vector3(10.81f, 3.0f, 14.0f);
        } else
        {
            return;
        }
        FadeOut();
        thePlayer.transform.position = playerPosition;
        FadeIn();
    }
}
