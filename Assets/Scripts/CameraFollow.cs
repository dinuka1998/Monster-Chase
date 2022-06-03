using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField]
    private float minX, maxX;
    private Transform player;
    private Vector3 temporaryPosition;
    private string PLAYER_TAG = "Player";

    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindWithTag(PLAYER_TAG).transform;
        // GameManager.instance.CharacterIndex;
        
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

        if(!player)
            return;
        
        temporaryPosition = transform.position;
        temporaryPosition.x = player.position.x;

        if(temporaryPosition.x < minX)
            temporaryPosition.x = minX;
        
        if(temporaryPosition.x > maxX)
            temporaryPosition.x = maxX;

        transform.position = temporaryPosition;

    }

} // class
