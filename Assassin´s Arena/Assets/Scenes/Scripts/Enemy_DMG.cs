using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.U2D;

public class HealthEnemy : MonoBehaviour
{
    public CircleCollider2D CircleCollider2D;
    public EnemyControll Behaviour;
    public Animator animator;
    private Transform target;
    private SpriteRenderer sprite;
    public Health HealthComponent;
    bool bletouch = false;
    float timer = 0;
    float attackTime = 1;


    void Start()
    {
        CircleCollider2D = GetComponent<CircleCollider2D>();
        Behaviour = GetComponent<EnemyControll>();
        animator = GetComponent<Animator>();
        target = FindObjectOfType<NewBehaviourScript>().transform;
        HealthComponent = FindObjectOfType<Health>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (bletouch)
        {
            animator.SetBool("Hitting", true);

            timer += Time.deltaTime;
            if (timer >= attackTime)
            {
                if (HealthComponent.currentHealth >= 1)
                {

                    timer = 0;
                   

                    if (target.position.x - transform.position.x <= -0.001)
                    {
                        sprite.flipX = true;
                    }
                    else
                    {
                        sprite.flipX = false;
                    }

                
                
                    HealthComponent.Damage(10);
                }
                else
                {
                    animator.SetBool("Hitting", false);
                }
               

            }


        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Behaviour.speed = 0;
            bletouch = true;
        }

        collision.gameObject.GetComponent<Health>();

    }

    private void OnTriggerStay(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Behaviour.speed = 0;
            bletouch = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if(collision.CompareTag("Player"))
        {
            Behaviour.speed = 5;
            bletouch = false;
            animator.SetBool("Hitting", false);
        }
      
    }
}
