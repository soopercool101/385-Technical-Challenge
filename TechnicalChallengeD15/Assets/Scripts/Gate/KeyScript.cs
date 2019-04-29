using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour {

    public GameObject gate;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gate.GetComponent<Animator>().SetTrigger("Unlock");
            this.gameObject.SetActive(false);
        }
    }
}
