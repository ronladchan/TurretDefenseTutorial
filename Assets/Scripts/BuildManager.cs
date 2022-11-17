using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    private GameObject turretToBuild;
    public GameObject standardTurretPrefab;
    public GameObject panelTurretPrefab;

    // Singleton pattern. A single build manager that can be easily referenced
    public static BuildManager instance;

    void Awake(){
        if (instance != null){
            Debug.Log("More than one build manager in scene");
            return;    
        }

        instance = this;
    }

    public GameObject GetTurretToBuild(){
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret){
        turretToBuild = turret;
    }
}
