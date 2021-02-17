using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerColor : MonoBehaviour
{
    private PlayerInput PI;
    private SpriteRenderer SR;

    // Start is called before the first frame update
    void Start()
    {
        PI = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInput>();
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PI.playerIndex == 0)
        {
            SR.color = Color.white;
        }
        else if (PI.playerIndex == 1)
        {
            SR.color = Color.black;
        }
    }
}
