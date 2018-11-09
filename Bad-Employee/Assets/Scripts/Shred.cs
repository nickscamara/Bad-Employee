using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shred : MonoBehaviour {

    public ParticleSystem ps;
    public ParticleSystem ps2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Debug.Log("Touched");
        BeltMovement.move = false;
        BeltMovement.destroy = true;
        Destroy(collision.gameObject); // maybe destroy the object
        
        ps.Play();
        ps2.Play();
    }
}
