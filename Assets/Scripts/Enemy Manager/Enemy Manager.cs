using System.Collections;
using System.Collections.Generic;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
   //base taken from in class assignment where we had to make a singleton and factory
    public static EnemyManager Instance { get; private set; }


    private int AmountOfEnemiesLeft=5;
    public int EnemiesToSpawn = 1;


    public string SceneName;

    private float timer = 0;

    public virtual void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); 
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }



    public void EndOfLevel() {


        if (timer < 1) {

            timer = 10f;
        
        }
        EnemiesToSpawn++;
        //scene stuff taken from GDW assignment
        SceneManager.LoadScene(SceneName);

    }


    public void StartTrackingEnemies() {

        StartCoroutine(EnemyTracking());
    
    }


    private IEnumerator EnemyTracking() {


        //was supposed to check if there are any enemies left but not working and not time ajnjoaisnfjosla
        /**
        while (AmountOfEnemiesLeft > 0) {

            //enemy finder thing taken from gdw thing also submitted for lab assignment
            GameObject[] enemies;
            enemies = GameObject.FindGameObjectsWithTag("Enemy");

            AmountOfEnemiesLeft = enemies.Length;


            yield return null;
        }
        */


        yield return new WaitForSeconds(timer);
        Debug.Log("a");
        EndOfLevel();
        yield return null;

    }


}
