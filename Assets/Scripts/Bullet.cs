using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Transform target;
    public float speed = 70f;
    public GameObject bulletImpactVFX;
    
    public void Seek(Transform _target){
        target = _target;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null){
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distanceThisFrame){
            HitTarget();
            return;
        }

        transform.Translate (dir.normalized * distanceThisFrame, Space.World);
        
    }

    void HitTarget(){
        GameObject VFXinst = (GameObject)Instantiate(bulletImpactVFX, transform.position, transform.rotation);
        Destroy(VFXinst, 2f);

        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
