using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : NPCBaseFSM
{
    private Vector3 direction;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        direction.x = opponent.transform.position.x - NPC.transform.position.x;
        direction.z = opponent.transform.position.z - NPC.transform.position.z;
        //direction.y = 0.276f;
        direction.y = 0f;
        //NPC.transform.LookAt(opponent);
        NPC.transform.rotation = Quaternion.Slerp(NPC.transform.rotation,
            Quaternion.LookRotation(direction),
            rotSpeed*(Time.deltaTime));
        NPC.transform.Translate(0, 0, Time.deltaTime * speed);
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
