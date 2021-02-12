using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerController PC;
    // Start is called before the first frame update
    void Start()
    {
        PC = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Green" && PC.IsShooting == true)
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Red" && PC.IsShooting == true)
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Green" && PC.IsShooting == true)
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Red" && PC.IsShooting == true)
        {
            Destroy(collision.gameObject);
        }
    }
    */

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Green" && PC.IsShooting == true)
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Red" && PC.IsShooting == true)
        {
            Destroy(collision.gameObject);
        }
    }
}
