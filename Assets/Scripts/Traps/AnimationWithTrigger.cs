using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationWithTrigger : MonoBehaviour
{

    public GameObject trap;

    // Start is called before the first frame update
    void Start()
    {
        trap.GetComponent<Animator>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (!hit.tag.Equals("Player")) return;
        trap.GetComponent<Animator>().enabled = true;
    }
}
