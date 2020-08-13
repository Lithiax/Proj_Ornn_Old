using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_OrderTaken : StateMachineBehaviour
{
    NpcAi npc;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateinfo, int layerindex)
    {
        animator.SetBool("OrderTaken", false);
        npc = animator.GetComponent<NpcAi>();

        npc.cloud.SetActive(false);
        npc.orderSprites = false;
        npc.state = "OrderTaken";

        npc.orderSystem.GetComponent<OrderManager>().UpdateOrders(npc.order);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateinfo, int layerindex)
    {

    }

}
