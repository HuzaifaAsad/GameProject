using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

public class waypoints : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Transform> Ways = new List<Transform>();
    private List<Vector3> vector = new List<Vector3>();
    
    int currentindex;

    int size = 5;
    Vector3 inputposition;
    public GameObject game;
  
    public GameObject point;
    private bool NewPoint = false;
    public int X;
    public int Y;
    private Quaternion rot;
    void Start()
    {
        foreach (Transform point in Ways)
        {
            // Ways.Add(point);
            vector.Add(point.position);

        }
        currentindex = 0;
        

    }
    // Update is called once per frame
    void Update()
    {

        Movement();
        

        // FollowPlane();
    }
    public void AddPoint()
    {
       
        Instantiate(game, inputposition, Quaternion.identity);
        NewPoint = true;
        // Debug.Log("Point Added");

    }
    public void FollowPlane()
    {
        Instantiate(point, transform.position, Quaternion.identity);
        // NewPoint = true;
        // Debug.Log("Path Added");

    }
    private void Movement()
    {
        inputposition = new Vector3(X, Y,0);
        // Debug.Log(inputposition);
        Vector3 dir = vector[currentindex] - transform.position;
        if (NewPoint)
        {
             dir = inputposition - transform.position;
        }
        
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        Quaternion targ = Quaternion.Euler(0, 0, angle-90f);
        transform.rotation = Quaternion.RotateTowards(
        transform.rotation,
        targ,
        150 * Time.deltaTime);
        
        if (currentindex < size && !NewPoint)
        {
            float distance = Vector2.Distance(vector[currentindex], transform.position);


            if (distance < 0.5f)
            {
                // hasarrived = true;
                currentindex = currentindex + 1;
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, vector[currentindex], 0.01f);

            }
        }
        else
        {
            currentindex = 0;
        }
        if (NewPoint)
        {


            transform.position = Vector2.MoveTowards(transform.position, inputposition, 0.01f);
        }
    }

}
