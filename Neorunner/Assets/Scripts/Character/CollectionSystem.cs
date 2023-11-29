using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionSystem : MonoBehaviour
{
   public static int amountCollected;
   public Collider2D trigger;
   public GameObject triggerObject, escapeText;
   public int finalAmount;
   public Text collectionText;

    void Update() {

        if (amountCollected == finalAmount){

            triggerObject.SetActive(true);
            escapeText.SetActive(true);
            //trigger.enable = true;
        }    
        collectionText.text = amountCollected + "/" + finalAmount;
    }
}
