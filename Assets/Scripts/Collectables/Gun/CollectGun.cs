using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGun : MonoBehaviour
{
    public AudioSource collectFX;
    public GameObject player;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        collectFX.Play();
        this.gameObject.SetActive(false);
        player.GetComponent<Animator>().SetBool("isJump", true);
        //CoinDisplay.coinCount++;
        
    }
}
