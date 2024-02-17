using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private GameObject wave2EnemyPrefab;
    [SerializeField]
    private GameObject wave3EnemyPrefab;

    private GameObject enemy;
    private GameObject enemy2;
    private GameObject enemy3;
    private int waveNum = 1;


    // Start is called before the first frame update
    void Start()
    {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);
            waveNum = 2;
    }

    void Update()
    {
            if(enemy == null && waveNum == 2){
                SpawnWave();
            enemy = Instantiate(wave2EnemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(-5, 1, -5);
            float angle2 = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle2, 0);
            enemy2 = Instantiate(wave2EnemyPrefab) as GameObject;
            enemy2.transform.position = new Vector3(5, 1, 5);
            float angle3 = Random.Range(0, 360);
            enemy2.transform.Rotate(0, angle3, 0);
            waveNum = 3;
            }else if(enemy == null && enemy2 == null && waveNum == 3){
            enemy = Instantiate(wave3EnemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(-5, 1, -5);
            float angle4 = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle4, 0);
            enemy2 = Instantiate(wave3EnemyPrefab) as GameObject;
            enemy2.transform.position = new Vector3(5, 1, 5);
            float angle5 = Random.Range(0, 360);
            enemy2.transform.Rotate(0, angle5, 0);
            enemy3 = Instantiate(wave3EnemyPrefab) as GameObject;
            enemy3.transform.position = new Vector3(5, 1, 5);
            float angle6 = Random.Range(0, 360);
            enemy3.transform.Rotate(0, angle6, 0);
            }
    }

private IEnumerator SpawnWave(){

        yield return new WaitForSeconds(3.0f);


    }




}

