using UnityEngine;
using UnityEngine.SceneManagement;

public class Moviment : MonoBehaviour
{
    public bool cant_move;
    public bool dead;

    public float speed = 4;
    public float jump_force = 5;
    public bool is_grounded = true;

    public float move_input;
    private bool turn_right = true;
    private Rigidbody2D rigid_body;

    private static Moviment instance = null;
    public static Moviment Instance()
    {
        return instance;
    }
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        rigid_body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (dead) return;
        move_input = Input.GetAxis("Horizontal");
        rigid_body.velocity = new Vector2(move_input * speed, rigid_body.velocity.y);

        if (turn_right == false && move_input > 0)
        {
            flip();
        }
        else if (turn_right == true && move_input < 0)
        {
            flip();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            jump();
        }

    }

    void flip()
    {
        turn_right = !turn_right;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

    public void jump()
    {
        if (is_grounded)
        {
            rigid_body.AddForce(Vector2.up * jump_force);
            is_grounded = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
        if (!hit.gameObject.tag.Equals("Damage")) return;
        cant_move = dead = true;
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.tag.Equals("Door"))
        {
            SceneManager.LoadScene("EndGame");
        }
        if (!hit.gameObject.tag.Equals("Damage")) return;
        cant_move = dead = true;
    }
}
