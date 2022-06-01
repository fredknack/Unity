using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateAnimator : MonoBehaviour
{
    private Animator crateAni;

    private bool lidOpen = false;
    
    void Awake()
    {
        crateAni = GetComponent<Animator>();
        openCrate();
    }

    // void OnTriggerEnter (Collider other)
    // {
    //     if(other.CompareTag("Player")){
    //         if(!lidOpen){
    //             lidOpen = true;
    //             GameManager.instance.SwitchWeapon(whichLoot);
    //             
    //             other.GetComponent<Player>().SwitchGun();
    //             openCrate();
    //         }
    //     }
    // }
    public void openCrate()
    {
        //print("openCrate");
        crateAni.SetBool("isOpen", true);
        //SoundManager.PlaySound(SoundManager.Sound.findItemOne);
        //StartCoroutine("LootBox");
    }


}
