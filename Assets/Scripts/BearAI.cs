using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearAI : MonoBehaviour
{
    Animator anim;
    public GameObject player;
    public GameObject eyes;
    public GameObject snore;
    public AnimatorClipInfo[] currAnim;

    public GameObject GetPlayer()
    {
        return player;
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        // if animation NOT sleep, turn off eyes turn off particle effect
        currAnim = anim.GetCurrentAnimatorClipInfo(0);
        Debug.Log(currAnim[0].clip.name);
        if (!((currAnim[0].clip.name).ToString() == "Bounce"))
        {
            eyes.SetActive(false);
            snore.SetActive(false);

        }
        else {
            eyes.SetActive(true);
            snore.SetActive(true);
        }

        // update distance from player and bear
        anim.SetFloat("distance", Vector3.Distance(transform.position, player.transform.position));
    }
}
