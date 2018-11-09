
using UnityEngine;
using System.Collections;
 
 public class Move : MonoBehaviour
{
    private const int VECTOR_COUNT = 5;
    private int vectorIndex = 0;
    private Vector3[] positionChanges;
    private Vector3 prevMousePosition;
    private float[] prevTimes;
    private bool curDown = false;
    private bool prevDown = false;
    public Rigidbody2D rigidbody2D;
    
    static bool pressed = false;
    void Start()
    {
       
        //rigidbody2D = GetComponent<Rigidbody2D>();
        prevMousePosition = Vector3.zero;
        positionChanges = new Vector3[VECTOR_COUNT];
        prevTimes = new float[VECTOR_COUNT];
        for (int i = 0; i < VECTOR_COUNT; i++)
        {
            positionChanges[i] = Vector3.zero;
            prevTimes[i] = 0;
        }
    }

    void Update()
    {
        if (curDown)
        {
            // if still down just follow the mouse (finger)
            Vector3 amountMoved = Camera.main.ScreenToWorldPoint(positionChanges[(vectorIndex - 1 + VECTOR_COUNT) % VECTOR_COUNT]) - Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
            transform.position = transform.position + amountMoved;
        }
        else if (prevDown)
        {
            // just came up so calculate and set velocity
            float totalTime = 0;
            Vector3 totalDistance = Vector3.zero;
            Vector3 velocity;
            for (int i = 0; i < VECTOR_COUNT; i++)
            {
                totalTime += prevTimes[i];
                totalDistance += positionChanges[i];
            }
            velocity = totalDistance / ( totalTime * 10 );
            velocity = Camera.main.ScreenToWorldPoint(velocity) - Camera.main.ScreenToWorldPoint(Vector3.zero);
            rigidbody2D.velocity = velocity;
        }

        positionChanges[vectorIndex] = Input.mousePosition - prevMousePosition;
        prevTimes[vectorIndex] = Time.deltaTime;
        vectorIndex = (vectorIndex + 1) % VECTOR_COUNT;

        prevDown = curDown;
        prevMousePosition = Input.mousePosition;

       
    }

    void OnMouseDown()
    {

        pressed = true;

        print("down");
        curDown = true;
        rigidbody2D.velocity = Vector2.zero;
    }

    void OnMouseUp()
    {
        print("up");
        curDown = false;
    }


    public static bool OnM()
    {
        if (pressed == true)
        {
            return true;
        }
        return false;
       
    }

}
