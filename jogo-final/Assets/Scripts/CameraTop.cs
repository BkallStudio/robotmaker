using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTop : MonoBehaviour
{

    public float velocidade = 5.0f;
    public Transform player;

    public Vector3 offset = Vector3.up;

    public bool lookAt = false;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.position + offset, velocidade * Time.deltaTime);
        if(lookAt)
        {
            transform.LookAt(player.position);
        }
    }
}
