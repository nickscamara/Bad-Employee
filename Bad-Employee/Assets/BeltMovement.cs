using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMovement : MonoBehaviour {


    public int speed = 20;
    public static bool move = false;
    public GameObject obj;
    bool collided = false;
    public static bool destroy = false;

	
	
	// Update is called once per frame
	void Update () {
        if (move)
        {
            obj.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Move.OnM() && destroy == false)
        {
            Debug.Log("diawdwad");
            move = false;
            obj.transform.Translate(Vector3.right * 0 * Time.deltaTime);
        }
            
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("COllision detected");
        if (col.gameObject.name == "box")
        {
            collided = true;
            move = true;

        }
        else {
            move = false;
        }
    }
}
