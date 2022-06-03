using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] monsterReference;
    private GameObject spawnMonster;
    [SerializeField]
    private Transform leftPosition, rightPosition;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnMonsters());

    }

    IEnumerator SpawnMonsters(){

        while(true)
        {
            
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, monsterReference.Length);
            randomSide = Random.Range(0, 2);

            spawnMonster = Instantiate(monsterReference[randomIndex]);

            //left
            if(randomSide == 0)
            {
                spawnMonster.transform.position = leftPosition.position;
                spawnMonster.GetComponent<Monster>().speed = Random.Range(4, 10);

            }
             //right
            else
            {

                spawnMonster.transform.position = rightPosition.position;
                spawnMonster.GetComponent<Monster>().speed = -Random.Range(4, 10);
                spawnMonster.transform.localScale = new Vector3(-1f, 1f, 1f);

            }

        }// while

    }
    

} // calss
