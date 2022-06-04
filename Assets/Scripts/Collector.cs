using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    private string ENEMY_TAG = "Enemy";
    private string PLAYER_TAG = "Player";

     private string UI_TAG = "UI";

    private Text deadText;

    private void Awake() {
        deadText = GameObject.FindWithTag(UI_TAG).GetComponent<Text>();
        deadText.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if(collision.CompareTag(ENEMY_TAG))
            Destroy(collision.gameObject);
        else if(collision.CompareTag(PLAYER_TAG))
        {

            deadText.enabled = true;
            Destroy(collision.gameObject);

        }
            

        
    }

}
