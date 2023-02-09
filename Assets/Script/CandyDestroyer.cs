using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    public CandyManager candyManager;
    public int reward;
    public GameObject effectPrefab;
    public Vector3 effectRotation;
   void OnTriggerEnter(Collider other){
    if(other.gameObject.tag=="Candy"){
        //オブジェクトを削除
        Destroy(other.gameObject);

        if(effectPrefab!=null){
            //Candyのポジションにエフェクトを作成
            Instantiate(
                effectPrefab,
                other.transform.position,
                Quaternion.Euler(effectRotation)
            );
        }
    }
   }
}
