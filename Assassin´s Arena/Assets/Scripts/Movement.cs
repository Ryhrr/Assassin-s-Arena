using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Rigidbody2D myRidgidbody;
    public Animator animator;


    public float MoveSpeed = 10.0f;

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

        if(MoveVertical >= 1 || MoveHorizontal >= 1)
        {

            animator.SetFloat("Speed", 1);

        }
        else
        {
            animator.SetFloat("Speed", 0);
        }


        
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
