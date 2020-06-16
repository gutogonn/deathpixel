using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifyGround : MonoBehaviour
{
    private GameObject lastPos, lastLastPos;

    private void Update()
    {
        if (lastPos == null) return;
        Debug.DrawLine(transform.position, lastPos.transform.position);
    }
    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.layer.Equals(8))
        {
            lastPos = new GameObject();
            lastPos.transform.position = gameObject.transform.position;
            lastPos.name = "last_pos";
            GetComponentInParent<Moviment>().is_grounded = true;
            Destroy(lastLastPos);
            lastLastPos = lastPos;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponentInParent<Moviment>().is_grounded = false;
    }
}
