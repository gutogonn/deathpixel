using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SpikePositionEnum
{
    UP, DOWN, LEFT, RIGHT
}

public class SpikePosition : MonoBehaviour
{
    private GameObject spike;
    public SpikePositionEnum pos;

    // Start is called before the first frame update
    void Awake()
    {
        spike = (GameObject)Instantiate(Resources.Load("Spike"));
        spike.name = "Spiker";
        spike.transform.SetParent(gameObject.transform);
        spike.transform.localScale = new Vector3(10, 10, 1);
        if (pos == SpikePositionEnum.UP)
        {
            spike.transform.position = new Vector3(
                gameObject.transform.position.x,
                gameObject.transform.position.y + 0.9f,
                gameObject.transform.position.z
            );
        }
        if (pos == SpikePositionEnum.DOWN)
        {
            spike.transform.position = new Vector3(
                gameObject.transform.position.x,
                gameObject.transform.position.y - 0.9f,
                gameObject.transform.position.z
            );
            spike.transform.rotation = new Quaternion(
                spike.transform.rotation.x,
                spike.transform.rotation.y,
                spike.transform.rotation.z + 180,
                spike.transform.rotation.w
            );
        }
        if (pos == SpikePositionEnum.LEFT)
        {
            spike.transform.position = new Vector3(
                gameObject.transform.position.x - 0.9f,
                gameObject.transform.position.y,
                gameObject.transform.position.z
            );
            spike.transform.rotation = new Quaternion(
                spike.transform.rotation.x,
                spike.transform.rotation.y,
                (spike.transform.rotation.z * 0) + 1,
                spike.transform.rotation.w
            );
        }
        if (pos == SpikePositionEnum.RIGHT)
        {
            spike.transform.position = new Vector3(
                gameObject.transform.position.x + 0.9f,
                gameObject.transform.position.y,
                gameObject.transform.position.z
            );
            spike.transform.rotation = new Quaternion(
                spike.transform.rotation.x,
                spike.transform.rotation.y,
                (spike.transform.rotation.z * 0) - 1,
                spike.transform.rotation.w
            );
        }
    }
}
