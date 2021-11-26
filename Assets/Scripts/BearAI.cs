using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearAI : MonoBehaviour
{
    Animator anim;
    public GameObject player;
    public GameObject eyes;
    public GameObject snore;
    private Vector3 npcPos;
    private Quaternion npcRot;
    public AnimatorClipInfo[] currAnim;

    public GameObject GetPlayer()
    {
        return player;
    }
    private void getNPCPos()
    {
        npcPos = transform.position;
        npcRot = transform.localRotation;

    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        getNPCPos();
    }


    // Update is called once per frame
    void Update()
    {
        // if animation NOT sleep, turn off eyes turn off particle effect
        currAnim = anim.GetCurrentAnimatorClipInfo(0);
        if (!((currAnim[0].clip.name).ToString() == "Bounce"))
        {
            eyes.SetActive(false);
            snore.SetActive(false);

        }
        else {
            eyes.SetActive(true);
            snore.SetActive(true);
        }

        // if state has tag "still" freeze npc position - for glancing around 
        //if (anim.tag.tostring() == "still")
        //{
        //    // check if current npc position had been captured
        //    if (transform.position != npcpos)
        //    {
        //        getnpcpos();
        //    }
        //    transform.position = npcpos;
        //}

        // update distance from player and bear
        anim.SetFloat("distance", Vector3.Distance(transform.position, player.transform.position));
    }
}
