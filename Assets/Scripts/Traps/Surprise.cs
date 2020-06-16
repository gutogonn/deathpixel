using UnityEngine;

public class Surprise : MonoBehaviour
{
    public GameObject trap;

    private void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log(this.gameObject.transform.childCount);
        trap = gameObject.transform.GetChild(0).gameObject;
        trap.SetActive(false);
        gameObject.name = "Trap_Surprise";
    }

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (!hit.tag.Equals("Player")) return;
        trap.SetActive(true);
        GetComponent<SpriteRenderer>().enabled = true;
    }
}
