using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAttachment : MonoBehaviour
{
    Vector3 camWork;
    public GameObject player;
    public float OffsetX;
    public float OffsetY;
    public float OffsetZ;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    
    void Update()
    {
        camWork = new Vector3(OffsetX, OffsetY, OffsetZ);
        transform.position = player.transform.position + camWork;
        transform.LookAt(player.transform);
        bool MousePersp = Input.GetMouseButton(1);
        float PerspMoveX = Input.GetAxis("Mouse X");
        float MoveAD = Input.GetAxis("Horizontal");
        float MoveWS = Input.GetAxis("Vertical");

        if (MoveWS > 0)
        {

        }
        else if (MoveWS < 0)
        {

        }

        if (MousePersp)
        {
            Debug.Log("clicking");
            if (PerspMoveX > 0)
            {

            }
            else if (PerspMoveX < 0)
            {


            }
        }

        else
        {
            if (MoveAD > 0)
            {

            }
            else if (MoveAD < 0)
            {

            }
        }
    }
}
