using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Waypoint;
    public GameObject plane;
    public List<GameObject> Objects = new List<GameObject>();
    public List<GameObject> Waypoints = new List<GameObject>();
    private float Timer = 0f;
    int[] marks = { 1, 2, 3, 4, 5 };
    int total = 5;
    public Dropdown Index;
    public Dropdown X;
    public Dropdown Y;


    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject newwaypoint = Instantiate(Waypoint, new Vector3(Random.Range(-40, 40), Random.Range(0, 30), 0), Quaternion.identity);
            Waypoints.Add(newwaypoint);

        }
        marks[2] = 40;
        // Debug.Log(marks[2]);

    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > 2f && Objects.Count < total)
        {
            GameObject newplane = Instantiate(plane, new Vector3(Random.Range(-40, 40), Random.Range(-30, -20), 0), Quaternion.identity);
            Objects.Add(newplane);
            Timer = 0;
            // Debug.Log("plane instantiated");

        }
        Timer += Time.deltaTime;


        for (int i = 0; i < Objects.Count; i++)
        {
            Objects[i].transform.position = Vector3.MoveTowards(Objects[i].transform.position, Waypoints[i].transform.position, 0.01f);
            Vector2 dir = Waypoints[i].transform.position - Objects[i].transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Quaternion targ = Quaternion.Euler(0, 0, angle - 90f);
            Objects[i].transform.rotation = Quaternion.RotateTowards(
            Objects[i].transform.rotation,
            targ,
            150 * Time.deltaTime);
            // Debug.Log(Objects.Count);
        }



    }
    public void ChangePosition()
    {
        int current = Index.value;
        int currentindex = int.Parse(Index.options[current].text);
        int currentX = X.value;
        int XPosition = int.Parse(X.options[currentX].text);
        int currentY = Y.value;
        int YPosition = int.Parse(Y.options[currentY].text);
        Debug.Log(currentindex);
        Debug.Log(XPosition);

        Debug.Log(YPosition);
        GameObject newpoint = Instantiate(Waypoint, new Vector3(XPosition, YPosition, 0), Quaternion.identity);
        Waypoints[currentindex] = newpoint;
        

    }
}
