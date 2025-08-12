using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAlerted : MonoBehaviour
{
    void OnTriggerEnter(Collider npc)
    {
        if (npc.CompareTag("NPC"))
        {
            // Get Animator component
            Animator anim = npc.GetComponent<Animator>();
            if (anim != null)
            {
                if (anim.HasParameter("isRunning"))
                {
                    anim.SetBool("isRunning", true); // Set Animator parameter
                }
                else
                {
                    Debug.LogWarning("Animator on '" + npc.name + "' does not have a parameter called 'isRunning'.");
                }
            }
            else
            {
                Debug.LogWarning("No Animator component found on '" + npc.name + "'.");
            }

            // Get NavMeshAgent component
            NavMeshAgent agent = npc.GetComponent<NavMeshAgent>();
            if (agent != null)
            {
                agent.speed = 7.5f;
            }
            else
            {
                Debug.LogWarning("No NavMeshAgent component found on '" + npc.name + "'.");
            }

            // Enable flee mode
            NPCAI.fleeMode = true;
        }
    }
}

public static class AnimatorExtensions
{
    public static bool HasParameter(this Animator animator, string paramName)
    {
        foreach (AnimatorControllerParameter param in animator.parameters)
        {
            if (param.name == paramName)
                return true;
        }
        return false;
    }
}
