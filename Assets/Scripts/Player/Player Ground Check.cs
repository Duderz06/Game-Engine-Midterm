using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{

    private PlayerMovement PM;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PM = FindAnyObjectByType<PlayerMovement>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Ground")) {


            PM.Grounded = true;
        
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {


            PM.Grounded = false;

        }

    }

}
