using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleMonch : MonoBehaviour
{
    Animator anim;
    public ParticleSystem love;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        love.playOnAwake = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        love.Play();
        if (other.CompareTag("apple"))
        {
            anim.SetBool("appleEat", true);
            love.Play();
            other.gameObject.tag = "eaten";
            other.gameObject.SetActive(false);
            love.Clear();
            anim.SetBool("appleEat", false);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("appleEat", false);
    }
}
