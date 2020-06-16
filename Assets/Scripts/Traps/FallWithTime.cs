using UnityEngine;

public class FallWithTime : MonoBehaviour
{
    public GameObject gameObject;
    private Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;
    public float timer = 5;
    private bool is_active;

    private void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
        gameObject.name = "Trap_Fall_With_Time";
    }

    private void Update()
    {
        if (!is_active) return;
        timer -= Time.deltaTime;
        if (timer > 0) return;
        rigidbody.constraints = RigidbodyConstraints2D.None;
        boxCollider.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (!hit.tag.Equals("Player")) return;
        is_active = true;
    }
}
