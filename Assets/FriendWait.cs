using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendWait : NPCBaseFSM
{
    private Vector3 npcPos;
    private Animator anim;
    private GameObject friendWaitTime;

    private void getNPCPos()
    {
        npcPos = NPC.transform.position;
    }
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        getNPCPos();
        anim = NPC.GetComponent<Animator>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        NPC.transform.position = npcPos;
        NPC.transform.LookAt(opponent.transform);
        anim.SetFloat("friendWaitTime",anim.GetCurrentAnimatorStateInfo(layerIndex).normalizedTime);
        Debug.Log(anim.GetCurrentAnimatorStateInfo(layerIndex).normalizedTime);

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
