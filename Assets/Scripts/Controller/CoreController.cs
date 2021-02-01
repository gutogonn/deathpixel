using UnityEngine;

public class CoreController : MonoBehaviour
{
    public PlayerController playerController;
    public GameController gameController;

    private static CoreController instance = null;
    public static CoreController Instance()
    {
        return instance;
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
        gameController = GetComponent<GameController>();
        playerController = GetComponent<PlayerController>();
    }
}
