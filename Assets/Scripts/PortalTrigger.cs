using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTrigger : MonoBehaviour
{
    [SerializeField] private GameObject signToTrigger;

    private void OnTriggerEnter(Collider other)
    {
        signToTrigger.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        signToTrigger.SetActive(false);
    }

}
