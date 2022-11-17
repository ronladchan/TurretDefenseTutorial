using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    private GameObject turretToBuild;

    // Singleton pattern. A single build manager that can be easily referenced
    public static BuildManager instance;

    void Awake(){
        if (instance != null){
            Debug.Log("More than one build manager in scene");
            return;    
        }

        instance = this;
    }

    public GameObject standardTurretPrefab;

    void Start(){
        turretToBuild = standardTurretPrefab;
    }

    public GameObject GetTurretToBuild(){
        return turretToBuild;
    }
}
