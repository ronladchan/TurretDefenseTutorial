using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 positionOffset;
    
    private GameObject turret;

    private Color startColor;
    private Renderer rend;

    void Start(){
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    // Calls once when mouse overlaps with the collider
    void OnMouseEnter(){
        // Want to change color on hover
        rend.material.color = hoverColor;
    }

    void OnMouseExit(){
        rend.material.color = startColor;
    }

    void OnMouseDown(){
        if(turret != null){
            Debug.Log("Can't build there");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }
}
