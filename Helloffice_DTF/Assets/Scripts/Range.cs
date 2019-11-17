using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Range : MonoBehaviour
{
    private EnemyMove parent;

    [SerializeField]
    public float max_see_distance = 40f;

    private void Start()
    {
        parent = GetComponentInParent<EnemyMove>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            parent.Target = collision.transform;
        }
    }

}
