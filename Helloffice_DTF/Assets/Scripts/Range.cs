using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Range : MonoBehaviour
{
    private EnemyMove parent;
    private CircleCollider2D circle_collider;


    private void Start()
    {
        parent = GetComponentInParent<EnemyMove>();
        circle_collider = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player Ghost")
        {
            parent.Target = collision.transform;
            parent.flag = true;
            circle_collider.enabled = false;

        }
    }

}
