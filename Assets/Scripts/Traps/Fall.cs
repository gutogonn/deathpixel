using UnityEngine;

public class Fall : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        gameObject.name = "Trap_Fall";
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (!hit.tag.Equals("Player")) return;
        rigidbody.constraints = RigidbodyConstraints2D.None;
        boxCollider.isTrigger = true;
    }
}
