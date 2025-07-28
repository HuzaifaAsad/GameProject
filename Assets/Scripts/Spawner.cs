using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Rendering;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    // public GameObject game;
    public GameObject game2;
    // public GameObject game2;
    Vector3 pos;
    int currentindex = 1;


    void Start()
    {

        transform.position = new Vector3(Random.Range(-60, 60), Random.Range(-60, 60), Random.Range(0, 0));


        game2.transform.position = new Vector3(Random.Range(-60, 60), Random.Range(-20, 20), Random.Range(0, 0));
        Instantiate(game2, game2.transform.position, Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = game2.transform.position - transform.position;
        transform.position = Vector3.MoveTowards(transform.position, game2.transform.position, 0.1f);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion targ = Quaternion.Euler(0, 0, angle - 90f);
        transform.rotation = Quaternion.RotateTowards(
        transform.rotation,
        targ,
        150 * Time.deltaTime);
    }

}


