using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EzWaveSpawner : MonoBehaviour
{
    public Transform greenEnemy;
    public Transform yellowEnemy;
    public Transform blueEnemy;

    public Transform spawnPoint;

    public float timeBetweenWaves = 3f;
    private float countdown = 3.5f;

    public TMP_Text waveCountDownText;

    private int waveIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown <= 0){
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }
        
        countdown -= Time.deltaTime;

        waveCountDownText.text = Mathf.Round(countdown).ToString();
        
    }

    IEnumerator SpawnWave(){
        waveIndex++;
        for (int i = 0; i < waveIndex; i++){
            SpawnGreenEnemy();
            yield return new WaitForSeconds(.25f);
        }
    }
    
    void SpawnGreenEnemy(){
        Transform greenEnemyClone = Instantiate(greenEnemy, spawnPoint.position, spawnPoint.rotation);
        greenEnemyClone = greenEnemy;
    }

    void SpawnYellowEnemy(int i){
        if (i % 2 == 1){
            Instantiate(yellowEnemy, spawnPoint.position, spawnPoint.rotation);
        }
    }

    void SpawnBlueEnemy(int i){
        if(i % 4 == 1){
            Instantiate(blueEnemy, spawnPoint.position, spawnPoint.rotation);
        }
    }
    
}
