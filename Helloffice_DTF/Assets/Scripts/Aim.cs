using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class Aim : MonoBehaviour
{

    [SerializeField]
    public string aimName;



    private AimParent aimPparent;


    // Start is called before the first frame update
    void Start()
    {
        aimPparent = GetComponentInParent<AimParent>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == aimName)
        {
            aimPparent.all_at_aim++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == aimName)
        {
            aimPparent.all_at_aim--;
        }
    }


}
