using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public Transform player;
    public float separacionX = 2f;
    public float separacionZ = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + separacionX, transform.position.y, player.position.z + separacionZ);
    }
}
