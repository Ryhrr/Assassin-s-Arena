using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControll : MonoBehaviour
{

    private Animator anim;
    private Transform target;
    private SpriteRenderer sprite;
    public float speed;
    [SerializeField]
    private float range;
    [SerializeField]
    private float minRange;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        target = FindObjectOfType<NewBehaviourScript>().transform;
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(target.position, transform.position)>= minRange)
        {
            FollowPlayer();


        }
        
    }

    public void FollowPlayer()
    {
        if(target.position.x - transform.position.x <= -0.001)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }
       
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
