using UnityEngine;
using UnityEngine.SceneManagement;

public class MapChange : MonoBehaviour
{
    public string next_map;

    private void OnCollisionEnter2D(Collision2D hit)
    {
        if (!hit.gameObject.tag.Equals("Player")) return;
        SceneManager.LoadScene(next_map);
    }
}
