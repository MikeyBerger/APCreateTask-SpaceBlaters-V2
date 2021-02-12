using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D RB;
    private Vector2 Movement;
    public float Speed;
    public float Timer;
    public bool IsShooting;

    IEnumerator StopShooting()
    {
        yield return new WaitForSeconds(Timer);
        IsShooting = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsShooting)
        {
            StartCoroutine(StopShooting());
        }
    }

    private void FixedUpdate()
    {
        RB.velocity = new Vector2(Movement.x, Movement.y) * Speed * Time.deltaTime;
        //transform.Translate(Movement.x * Speed, Movement.y * Speed, 0);
    }


    #region InputActions
    public void OnMove(InputAction.CallbackContext ctx)
    {
        Movement = ctx.ReadValue<Vector2>();
    }

    public void OnShoot(InputAction.CallbackContext ctx)
    {
        if (ctx.phase == InputActionPhase.Performed)
        {
            IsShooting = true;
        }
    }
    #endregion
}
