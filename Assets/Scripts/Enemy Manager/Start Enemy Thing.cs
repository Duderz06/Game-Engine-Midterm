using UnityEngine;

public class StartEnemyThing : MonoBehaviour
{

    //taken from gdw assignemt also used for lab
    private EnemyManager EM;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EM = EnemyManager.Instance;

        EM.StartTrackingEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
