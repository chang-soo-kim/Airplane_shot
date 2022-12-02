using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollewPlayer : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(20, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = player.transform.position + new Vector3(0,20f,-30f);   
    }
}
