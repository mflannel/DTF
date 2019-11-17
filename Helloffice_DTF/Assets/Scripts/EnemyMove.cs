using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D enemy_body;

    [SerializeField]
    private float speed_multiplier;

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

    private Vector2 movement;

    private void Awake()
    {
        enemy_body = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Player").transform;
    }



    // Update is called once per frame
    void Update()
    {
        movement = target.position - transform.position;
        movement.Normalize();
    }

    void FixedUpdate()
    {
        FollowTarget(movement);
    }

    void FollowTarget(Vector2 direction)
    {
        if (target != null)
        {
            enemy_body.MovePosition((Vector2)transform.position + (direction * speed_multiplier * Time.deltaTime));
        }

    }
}
