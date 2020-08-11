using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Ordering : StateMachineBehaviour
{
    NpcAi npc;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        npc = animator.GetComponent<NpcAi>();

        if (!npc.orderSprites)
            npc.initiateOrderSprites();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (npc.interactArea.GetComponent<Interactable>().interact() == true)
            npc.OrderTaken();
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

}
