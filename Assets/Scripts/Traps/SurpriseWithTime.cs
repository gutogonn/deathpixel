using UnityEngine;

public class SurpriseWithTime : MonoBehaviour
{
    public GameObject trap;
    public float timer;
    private bool is_active;

    private void Start()
    {
        trap = gameObject.transform.GetChild(0).gameObject;
        trap.SetActive(false);
        GetComponent<SpriteRenderer>().enabled = false;
        gameObject.name = "Trap_Surprise_With_Time";
    }

    private void Update()
    {
        if (!is_active) return;
        timer -= Time.deltaTime;
        if (timer > 0) return;
        trap.SetActive(true);
        GetComponent<SpriteRenderer>().enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (!hit.tag.Equals("Player")) return;
        is_active = true;
    }

}
