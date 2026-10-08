using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float MoveSpeed = 5f;
    private float JumpPower = 8f;

    private Rigidbody RB;

    public bool Grounded = true;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Movement = Vector3.zero;

        if (Input.GetKey(KeyCode.D))
        {

            Movement.x += MoveSpeed;

        }


        if (Input.GetKey(KeyCode.A))
        {

            Movement.x -= MoveSpeed;

        }

        Vector3 BasVel = RB.linearVelocity;

        BasVel.x = Movement.x;



        if (Input.GetKeyDown(KeyCode.Space)&&Grounded) {


            BasVel.y = JumpPower;

        
        }

        RB.linearVelocity = BasVel;

    }


    public float GetSpeed() { 
    
        return MoveSpeed;
    
    }

    public float GetJumpPower()
    {

        return JumpPower;

    }


    public void SetSpeed(float speed)
    {

        MoveSpeed = speed;

    }

    public void SetJumpPower(float jump)
    {

        JumpPower = jump;

    }
}
