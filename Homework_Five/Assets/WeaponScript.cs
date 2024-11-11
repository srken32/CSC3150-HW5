using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float shootRange = 10f;
    [SerializeField] ParticleSystem muzzleFlash;
    // [SerializeField] GameObject hitEffect;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    private void PlayMuzzleFlash(){
        muzzleFlash.Play();
    }

    private void Shoot(){
        RaycastHit hit;
        PlayMuzzleFlash();
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, shootRange)){
            Debug.Log("I hit an object: ");
            // CreateHitImpact(hit);
        }else{
            return;
        }
    }

    // private void CreateHitImpact(RaycastHit hit){
    //     GameObject impact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
    //     Destroy(impact, 1);
    // }
}
