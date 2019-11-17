using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D enemy_body;

    [SerializeField]
    private float speed_multiplier = 6;

    private Transform target;
    public Transform Target
    {
        get
        {
            return Target;
        }

        set
        {
            target = value;
        }
    }

    public bool flag = false;

    private Vector2 movement;
    //private CapsuleCollider2D capsule_collider;

    private void Awake()
    {
        enemy_body = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        target = null;
    }



    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            movement = target.position - transform.position;
            movement.Normalize();
        }
    }

    void FixedUpdate()
    {
        FollowTarget(movement);
    }

    void FollowTarget(Vector2 direction)
    {
        if (target != null)
        {
            //capsule_collider.enabled = true;
            enemy_body.MovePosition((Vector2)transform.position + (direction * speed_multiplier * Time.deltaTime));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (flag && (collision.tag == "Player Yellow" || collision.tag == "Player Red"
        || collision.tag == "Player Green" || collision.tag == "Player Ghost"))
        {
            LevelRestart();
        }
    }

    void LevelRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
