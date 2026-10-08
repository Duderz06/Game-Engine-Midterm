using UnityEngine;

public class spawnbublbe : MonoBehaviour
{
    public GameObject bubble;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {


            Instantiate(bubble,transform.position,transform.rotation);
        
        }
    }
}
