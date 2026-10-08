using System.Collections;
using UnityEngine;

public class Enemy2 : Enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Start();

        StartCoroutine(ChangeDirTimer());
    }


    public IEnumerator ChangeDirTimer() {

        while (true) {

            float timer = 3f;

            float Timer = 0f;

            while (timer > Timer) {

                Timer += Time.deltaTime;
                yield return null;

            }



            ChangeDir();
            yield return null;
        }
    
    
    }



}
