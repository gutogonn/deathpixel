using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class GoogleApiController : MonoBehaviour
{

    public List<Achievement> achievements;
    private PlayGamesPlatform platform;

    // Start is called before the first frame update
    void Start()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        platform = PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {

            if (success)
            {
                Debug.Log("logged in");
            }
            else
            {
                Debug.Log("failed log in");
            }

        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
