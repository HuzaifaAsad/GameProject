using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Rendering;

public class Move : MonoBehaviour
{

    public List<GameObject> Objects = new List<GameObject>();
    public List<GameObject> Waypoints = new List<GameObject>();


    void Start()
    {
        foreach (GameObject plane in Objects)
        {
            Vector3 pos = plane.transform.position;
            pos = new Vector3(Random.Range(0, 10), Random.Range(10, 20), Random.Range(0,0));
            Instantiate(plane,pos,Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}


