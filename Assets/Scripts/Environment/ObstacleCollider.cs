using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollider : MonoBehaviour
{
    public GameObject player;

    public GameObject charModel;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collided with");
        Debug.Log(this.gameObject);
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<Move>().enabled = false;

        //charModel.GetComponent<Animator>().Play("Jump");
        charModel.GetComponent<Animator>().SetBool("isStumble", true);
        /*if (player.GetComponent<Animator>())
        {
            this.player.GetComponent<Animator>().SetBool("isJump", true);

            //this.player.GetComponent<Animator>().Play("Jump");
            this.gameObject.SetActive(false);
        }*/
    }
    /* public GameObject player;

    //public AnimatorController();
    
    private Animator animator;

    void Start()
    {
        animator = player.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
        //if (other.CompareTag("Player"))
        //{
            Debug.Log("stumble");
            animator.SetBool("isStumble", true);
        //}
    }*/
}
