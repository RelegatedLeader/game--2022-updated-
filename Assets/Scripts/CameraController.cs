using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    public float offset;
    public float offSetSmoothing;
    private Vector3 playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = new Vector3 (player.transform.position.x, transform.position.y, transform.position.z); //automatically accepts it 
        //player.transform.position y is if you want it to follow you through the y axis 

        if(player.transform.localScale.x > 0f)
        {
            playerPosition =  new Vector3(playerPosition.x + offset, playerPosition.y,playerPosition.z);
        }
        else
        {
            playerPosition = new Vector3(playerPosition.x - offset, playerPosition.y, playerPosition.z);

        }
        transform.position = Vector3.Lerp(transform.position, playerPosition, offSetSmoothing * Time.deltaTime);
    }
}
