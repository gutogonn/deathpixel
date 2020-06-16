using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player player;
    public Moviment playerGO;

    private void Start()
    {
        player.health = 1;
        player.point = 5; 
    }

    private void FixedUpdate()
    {
        playerGO = GameObject.FindWithTag("Player") ? GameObject.FindWithTag("Player").GetComponent<Moviment>() : null;
        if (playerGO == null) return;
        if (isDead())
        {
            if (playerGO.cant_move)
            {
                playerGO.jump();
                playerGO.gameObject.GetComponent<CapsuleCollider2D>().isTrigger = true;
                playerGO.gameObject.tag = "Dead";
                FactoryController.Instance().gameController.justDied();
                playerGO.cant_move = false;
            }
        }
    }

    private bool isDead()
    {
        if (!playerGO.dead) return false;
        player.point--;
        return true;
    }
}
