using UnityEngine;

public class bubble : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) { 
        
        
            Destroy(collision.gameObject);
        
        }

        if (!collision.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);


        }

    }
}
