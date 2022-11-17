// using UnityEngine;
// using System.Collections;

// public class WaveSpawner : MonoBehaviour
// {   
    
//     public Transform greenEnemyPrefab;
//     public Transform yellowEnemyPrefab;
//     public Transform blueEnemyPrefab;

//     // Time between each wave during the round
//     public float timeBetweenWaves = 3f;
    
//     // Delay at the start of each round before waves start spawning 
//     private float countdown = 1f;

//     // Need a notion of a round to pass a variable number to generate wave creation
//     private float round = 0;

//     // List to store the enemies for the round
//     // static public List<GameObject> waveList;


//     void Start(){
//         WaveCreator(round);
//         List<GameObject> waveList = new List<GameObject>();
//     }

//     void WaveCreator(float round){
//         float numGreenEnemies = round * 3f;
//         float numYellowEnemies = round * 2f;
//         float numBlueEnemies = round * 1f;

//         // Idk coroutines yet so it should first spawn all green enemies, then yellow, then blue
//         if(numGreenEnemies != 0){
//             waveList.Add(greenEnemyPrefab);
//             numGreenEnemies -= 1;
//         } 

//         if (numYellowEnemies != 0){
//             waveList.Add(yellowEnemyPrefab);
//             numYellowEnemies -= 1;
//         } 
        
//         if (numBlueEnemies != 0){
//             waveList.Add(blueEnemyPrefab);
//             numBlueEnemies -= 1;
//         } 
//     }

//     void Update(){
        
//         if (countdown <= 0){
//             SpawnWave();
//             countdown = timeBetweenWaves;
//         }
        
//         countdown -= Time.deltaTime;

//         // Need something that marks the end of a round (last wave spawns) and starts the next (add 1 to round)
//         // This solution below assumes that after we calculate the enemies in the list,
//         // we remove enemies off the list as we spawn each one
//         if(waveList.Length == 0){
//             round += 1;
//         }

//     }

//     void SpawnWave(){
//         Debug.Log("Wave Incoming");
//         // Instantiate(gameObject, position, rotation)

//         for (int i = 0; i < waveList.Length - 1; i++){
//             if(waveList<i> == GameObject.name.GreenEnemy){
//                 Debug.Log("greenEnemyPrefab");
//             }
//             else if (waveList<i> == GameObject.name.YellowEnemy){
//                 Debug.Log("yellowEnemyPrefab");
//             }
//             else if (waveList<i> == GameObject.name.BlueEnemy){
//                 Debug.Log("blueEnemyPrefab");
//             }
//         }

//     }

// }

// // // System.Serializable allows you to configure all of the properties below
// //     // in the Inspector like a public variable
// //     [System.Serializable]
// //     public class Wave {

// //         public string name;
// //         public Transform greenEnemy;
// //         public Transform yellowEnemy;
// //         public Transform blueEnemy;
// //         public int count;
// //         public float rate;

// //     }

// //     private static List<GameObject> waveList = new List<GameObject>();