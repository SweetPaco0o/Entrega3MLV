using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpenBehaviourChest : StateMachineBehaviour
{
    public Transform _player;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public bool CheckPlayer(Transform mySelf)
    {
        float distance = Vector3.Distance(_player.position, mySelf.position);
        return distance > 10;
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        bool isPlayerClose = CheckPlayer(animator.transform);
        animator.SetBool("PlayerClose", !isPlayerClose);
    }
}
