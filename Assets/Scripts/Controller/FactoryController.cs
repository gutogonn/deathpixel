using UnityEngine;

public class FactoryController : MonoBehaviour
{
    public PlayerController playerController;
    public GameController gameController;
    public MobileController mobileController;

    private static FactoryController instance = null;
    public static FactoryController Instance()
    {
        return instance;
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
        gameController = GetComponent<GameController>();
        playerController = GetComponent<PlayerController>();
        if (Application.platform == RuntimePlatform.Android){ mobileController = GetComponent<MobileController>(); }
            
    }
}
