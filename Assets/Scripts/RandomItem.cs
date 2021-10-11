using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomItem : MonoBehaviour
{
    List<string> Shapes = new List<string>();
    int listLenght;
    int index;

    // Start is called before the first frame update
    void Start()
    {
        Shapes.AddRange(new List<string> {
        "Firkant", "Cirkel", "Trekant" });
        listLenght = Shapes.Count;
        
    }

    // Update is called once per frame
    void Update()
    {
        index = Random.Range(0, listLenght - 1);
        RandomOrder(4, Shapes);
    }

    void RandomOrder(int num_items_need, List<string> items)
    {
        print("ok");
    }
}
