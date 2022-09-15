using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private Vector3 addPosition = new  Vector3(0,0,-2);
    private float keyTime;
    private float TimeInterval = 3.0f;

    private void Start()
    {
        //when the game start the space bar time is 3s
        keyTime = TimeInterval;
    }
    // Update is called once per frame
    void Update()
    {
        //the space bar time incraeses by 1s everytime in the game
        keyTime += Time.deltaTime * 1;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && keyTime >= TimeInterval)
        {
            Instantiate(dogPrefab,transform.position + addPosition, dogPrefab.transform.rotation);

            //on space bar down the time returns to zero
            keyTime = 0;
        }
    }
}
