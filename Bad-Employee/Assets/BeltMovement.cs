using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMovement : MonoBehaviour {


    public int speed = 20;
    bool move = false;
    public GameObject obj;
	
	
	// Update is called once per frame
	void Update () {
        if (move)
        {
            obj.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("COllision detected");
        if (col.gameObject.name == "box")
        {
            move = true;
            
        }
    }
}
