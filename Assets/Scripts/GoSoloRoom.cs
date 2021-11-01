using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoSoloRoom : MonoBehaviour
{
    public GameObject thePlayer;
    public FadeManager fadeManager;
    private Vector3 playerPosition;

    private void OnTriggerEnter(Collider other)
    {

        playerPosition = (this.CompareTag("EnterTherapyRoom")) ? new Vector3(1.75f, 2f, 1.75f) : new Vector3(0, 0, 0);

        //transition.SetActive(true);
        //thePlayer.SetActive(false);
        StartCoroutine(FinishFade());
    }

    IEnumerator FinishFade()
    {
        fadeManager.Fade(true, 1.25f);
        yield return new WaitForSeconds(2f);
        //GetComponent<Collider>().enabled = false;
        fadeManager.Fade(false, 2f);
        thePlayer.transform.position = playerPosition;
        playerPosition = new Vector3(0, 0, 0);

        //transition.SetActive(false);
    }

}
