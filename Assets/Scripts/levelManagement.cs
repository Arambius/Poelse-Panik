using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class levelManagement : MonoBehaviour
{
    GameObject gameManager;
    RandomOrderGenerator randomOrderGeneratorRef;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        randomOrderGeneratorRef = gameManager.GetComponent<RandomOrderGenerator>();
        randomOrderGeneratorRef.itemsNeeded = 4;
        print(randomOrderGeneratorRef.itemsNeeded);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
