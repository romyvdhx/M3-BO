using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    Animator m_Animator;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //Press the up arrow button to reset the trigger and set another one
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("e was pressed");
            //Reset the "Crouch" trigger
            m_Animator.ResetTrigger("Idle");

            //Send the message to the Animator to activate the trigger parameter named "Jump"
            m_Animator.SetTrigger("Walk");
        }

        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("r was pressed");
            //Reset the "Jump" trigger
            m_Animator.ResetTrigger("Walk");

            //Send the message to the Animator to activate the trigger parameter named "Crouch"
            m_Animator.SetTrigger("Idle");
        }
    }
}
