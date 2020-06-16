using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationWithTriggerWithTime : MonoBehaviour
{

    public GameObject trap;
    public float timer;
    public bool never_stop;
    private bool is_active;

    // Start is called before the first frame update
    void Start()
    {
        trap.GetComponent<Animator>().enabled = false;
    }

    private void Update()
    {
        if (!is_active) return;
        timer -= Time.deltaTime;
        if (timer > 0) return;
        trap.GetComponent<Animator>().enabled = true;
        if (never_stop) return;
        is_active = false;
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (!hit.tag.Equals("Player")) return;
        is_active = true;
    }
}
