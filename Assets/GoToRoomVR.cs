using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToRoomVR : OVRScreenFade
{
    [SerializeField] private GameObject thePlayer;
    private Vector3 playerPosition;

    private void OnTriggerEnter(Collider other)
    {
        playerPosition = (this.CompareTag("EnterTherapyRoom")) ? new Vector3(9.88f, 3f, -9.54f) : thePlayer.transform.position;
        playerPosition = (this.CompareTag("EnterWaitingRoom")) ? new Vector3(6.06f, 3f, 14) : thePlayer.transform.position;
        FadeOut();
        thePlayer.transform.position = playerPosition;
        FadeIn();
    }
}
