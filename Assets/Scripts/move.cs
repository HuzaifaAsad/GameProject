using System;
using System.Collections;
using System.Collections.Generic;
// using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using UnityEngine;
using UnityEngine.Rendering;

public class Move : MonoBehaviour
{

    public List<GameObject> Objects = new List<GameObject>();
    public List<GameObject> Waypoints = new List<GameObject>();

    int[] marks = { 1, 2, 3, 4, 5 };
    int[] copy = new int[5];

    void Start()
    {
        // foreach (GameObject plane in Objects)
        // {
        //     Vector3 pos = plane.transform.position;
        //     pos = new Vector3(Random.Range(0, 10), Random.Range(10, 20), Random.Range(0, 0));
        //     Instantiate(plane, pos, Quaternion.identity);
        // }



        // Update is called once per frame


    }
}


