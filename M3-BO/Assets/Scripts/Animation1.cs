using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Animation : MonoBehaviour
{
    private Animator ryuk;
    PlayerActions controls;

    // Start is called before the first frame update
    void Awake()
    {
        controls = new PlayerActions();
        controls.Gameplay.Enable();
        ryuk = GetComponent<Animator>();
        //ryuk.SetTrigger("Standing Idle");
    }

    void GetBow()
    {
        ryuk.SetTrigger("GetBow");
        ryuk.ResetTrigger("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        if(controls.Gameplay.GrabBow.IsPressed())
        {
            Debug.Log("e was pressed");
            GetBow();
        }
    }
}
