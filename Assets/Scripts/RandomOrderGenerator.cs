using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class RandomOrderGenerator : MonoBehaviour
{
    List<string> itemsOnMenu = new List<string>();
    public int itemsNeeded = 4;

    // Start is called before the first frame update
    void Start()
    {
        itemsOnMenu.AddRange(new List<string> {
        "pølle", "remoulade", "ketchup", "brød"});

        List<string> order = new List<string>();
        RandomOrder(itemsNeeded, itemsOnMenu, order);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void RandomOrder(int NumIteamsNeeded, List<string> iteamsOnMenu, List<string> order)
    {
        foreach (int value in Enumerable.Range(0, NumIteamsNeeded))
        {
            order.Add(iteamsOnMenu[Random.Range(0, iteamsOnMenu.Count)]);
        }
    }
}