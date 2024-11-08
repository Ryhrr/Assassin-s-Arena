using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;


public class NewBehaviourScript : MonoBehaviour
{

    public Rigidbody2D myRidgidbody;
    public Animator animator;
    private SpriteRenderer sprite;


    public float MoveSpeed = 6.0f;

    private float MoveHorizontal = 1f;
    private float MoveVertical = 1f;

    // Start is called before the first frame update
    void Start()
    {


        myRidgidbody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {



        MoveHorizontal = Input.GetAxisRaw("Vertical");
        MoveVertical = Input.GetAxisRaw("Horizontal");


        if (Input.GetKey(KeyCode.W) == true)
        {
            animator.SetBool("running", true);
        }
        else if (Input.GetKey(KeyCode.S) == true)
        {
            animator.SetBool("running", true);
        }
        else if (Input.GetKey(KeyCode.D) == true)
        {
            animator.SetBool("running", true);
            sprite.flipX = true;
        }
        else if(Input.GetKey(KeyCode.A) == true)
        {
            animator.SetBool("running", true);
            sprite.flipX = false;
        }
        else
        {
            animator.SetBool("running", false);
        }


        if (Input.GetKey(KeyCode.W) == true & Input.GetKey(KeyCode.D) == true || Input.GetKey(KeyCode.W) == true & Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.S) == true & Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.S) == true & Input.GetKey(KeyCode.D) == true)
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

