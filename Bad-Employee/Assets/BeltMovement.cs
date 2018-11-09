using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMovement : MonoBehaviour {


    public int speed = 20;
<<<<<<< HEAD
    public static bool move = false;
    public GameObject obj;
    bool collided = false;
    public static bool destroy = false;

=======
    bool move = false;
    public GameObject obj;
>>>>>>> parent of 5c6c9dc... mid day
	
	
	// Update is called once per frame
	void Update () {
        if (move)
        {
            obj.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
<<<<<<< HEAD
        else if (Move.OnM() && destroy == false)
        {
            Debug.Log("diawdwad");
            move = false;
            obj.transform.Translate(Vector3.right * 0 * Time.deltaTime);
        }
            
        
=======
>>>>>>> parent of 5c6c9dc... mid day
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("COllision detected");
        if (col.gameObject.name == "box")
        {
<<<<<<< HEAD
<<<<<<< HEAD
            obj = col.gameObject;
=======
>>>>>>> parent of 7df2ac8... g
            collided = true;
=======
>>>>>>> parent of 5c6c9dc... mid day
            move = true;
            
        }
    }
}
