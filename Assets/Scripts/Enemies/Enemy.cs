using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    protected float MoveSpeed= 3f;

    private Rigidbody RB;

    private bool GoingLeft=false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected void Start()
    {
        RB = GetComponent<Rigidbody>();

        StartCoroutine(move());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public virtual IEnumerator move() {

        Vector3 Movement;


        while (true) {


            Movement.x = 0;
            Movement.y = RB.linearVelocity.y;
            Movement.z = 0;

            if (GoingLeft)
            {
                Movement.x -= MoveSpeed;
            }

            else {

                Movement.x += MoveSpeed;

            }

            RB.linearVelocity = Movement;

            yield return null;
        }
    
    
    }


    public void ChangeDir() {

        GoingLeft = !GoingLeft;
    
    }


}
