using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D player_body;

    [SerializeField]
    private float speed_multiplier;

    private void Awake()
    {
        player_body = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        player_body.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed_multiplier, 0.8f),
                                    Mathf.Lerp(0, Input.GetAxis("Vertical") * speed_multiplier, 0.8f));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
