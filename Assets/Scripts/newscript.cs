using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Plane : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public GameObject obj2;
    Vector3 pos;
    List<int> marks = new List<int>(){10,20,30,40};
    
    Vector3 pos2;
    Transform trans;

    void Start()
    {
        pos = obj.transform.position;
        pos2 = obj2.transform.position;
        trans = obj.transform;
        foreach (int m in marks)
        {
            Debug.Log(m);
        }
        

    }

    // Update is called once per frame

    void Update()
    {
        float distance = Vector3.Distance(pos, transform.position);
        float distance2 = Vector3.Distance(pos2, pos);

        if (Input.GetKey(KeyCode.Space))
        {
            if (distance > 5)
            {
                Vector3 dir = (pos - transform.position).normalized;
                transform.Translate(dir * Time.deltaTime * 20);
                Debug.Log("First");
            }
            else
            {
                Vector3 dir2 = (pos2 - pos).normalized;
                trans.Translate(dir2 * Time.deltaTime * 20);
                Debug.Log("Second");
            }
        }


    }
}
