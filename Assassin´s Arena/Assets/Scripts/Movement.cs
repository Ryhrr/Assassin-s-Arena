using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Rigidbody2D myRidgidbody;
    

    public float MoveSpeed = 300.0f;

    private float MoveHorizontal = 1f;
    private float MoveVertical = 1f;

    // Start is called before the first frame update
    void Start()
    {


        myRidgidbody = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {


        MoveHorizontal = Input.GetAxisRaw("Vertical");
        MoveVertical = Input.GetAxisRaw("Horizontal");

        


        
        if(Input.GetKey(KeyCode.W) == true & Input.GetKey(KeyCode.D) == true || Input.GetKey(KeyCode.W) == true & Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.S) == true & Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.S) == true & Input.GetKey(KeyCode.D) == true)
        {

            MoveSpeed = MoveSpeed / 1.5f;

            myRidgidbody.velocity = new Vector2(MoveHorizontal * MoveSpeed, myRidgidbody.velocity.y);


            myRidgidbody.velocity = new Vector2(MoveVertical * MoveSpeed, myRidgidbody.velocity.x);

            MoveSpeed = MoveSpeed * 1.5f;
        }
        else
        {
            myRidgidbody.velocity = new Vector2(MoveHorizontal * MoveSpeed, myRidgidbody.velocity.y);


            myRidgidbody.velocity = new Vector2(MoveVertical * MoveSpeed, myRidgidbody.velocity.x);
        }



    }
}
