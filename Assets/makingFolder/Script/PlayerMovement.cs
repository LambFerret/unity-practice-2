using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    Vector3 playerDir;      //보는 방향
    public float speed;     // 이동속도



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        if (h > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            playerDir = Vector3.right;
        }
        else if (h < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            playerDir = Vector3.left;

        }
        rb.AddForce(Vector3.right * h, ForceMode.Impulse);
        if (rb.velocity.x > speed)
            rb.velocity = new Vector3(speed, rb.velocity.y);
        else if (rb.velocity.x < speed * (-1))
            rb.velocity = new Vector3(speed * (-1), rb.velocity.y);

    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
