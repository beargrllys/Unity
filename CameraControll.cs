using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{

    public GameObject Player;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = this.transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = Player.transform.position + (offset*2);
    }
}
