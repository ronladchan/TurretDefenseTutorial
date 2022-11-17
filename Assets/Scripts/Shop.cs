using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    // Could reference the build manager, but let's just cache the build manager
    BuildManager buildManager;

    void Start(){
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret(){
        Debug.Log("Standard Turret Purchased");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
    }

    public void PurchasePanelTurret(){
        Debug.Log("Panel Turret Purchased");
        buildManager.SetTurretToBuild(buildManager.panelTurretPrefab);
    }

    public void PurchaseMissileTurret(){
        Debug.Log("Missile Turret Purchased");
    }

    public void PurchaseLaserTurret(){
        Debug.Log("Laser Turret Purchased");
    }
    
}
