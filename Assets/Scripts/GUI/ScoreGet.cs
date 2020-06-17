using UnityEngine;
using UnityEngine.UI;

public class ScoreGet : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = CoreController.Instance().playerController.player.point.ToString();  
    }
}
