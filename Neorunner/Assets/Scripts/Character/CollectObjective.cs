using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObjective : MonoBehaviour
{
   public GameObject thisobject;
   public AudioSource collect;

   void OnTriggerEnter2D(Collider2D other) {

    if(other.CompareTag("Player")){

        //Audio player, still looking for SFX
        //pickup.Play();

        CollectionSystem.amountCollected = CollectionSystem.amountCollected + 1;
        thisobject.SetActive(false);

    }
    
   }
    
}
