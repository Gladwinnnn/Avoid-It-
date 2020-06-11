using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    bool cooldown = false;
    [SerializeField] bool autoPlay;
    [SerializeField] float minJumpDelay = 0.5f;
    [SerializeField] float maxJumpDelay = 2f;
    [SerializeField] float speed;
    [SerializeField] Vector2 direction = Vector2.right;

    void Start()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);

        if (!autoPlay)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Jump();
            }
        }

        else
        {
            if (cooldown == false)
            {
                rigidbody2d.AddForce(new Vector2(0,10) * 50,ForceMode2D.Impulse);
                Invoke("ResetCooldown",1f);
                cooldown = true;
            }
        }
    }

    public void Jump()
    {
        if (cooldown == false)
        {
            rigidbody2d.AddForce(new Vector2(0,10) * 50,ForceMode2D.Impulse);
            Invoke("ResetCooldown",0.4f);
            cooldown = true;
        }
    }

    void ResetCooldown()
    {
        cooldown = false;
    }
}
