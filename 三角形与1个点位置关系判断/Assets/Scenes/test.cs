using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public GameObject[] triangle;
    public GameObject point;
    float[] dot = new float[3];
    // Use this for initialization
    void Start()
    {

        float[] len = new float[triangle.Length];

        len[0] = Vector3.Distance(triangle[0].transform.position, triangle[1].transform.position);
        len[1] = Vector3.Distance(triangle[1].transform.position, triangle[2].transform.position);
        len[2] = Vector3.Distance(triangle[2].transform.position, triangle[0].transform.position);



    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(triangle[0].transform.position, triangle[1].transform.position, Color.yellow);
        Debug.DrawLine(triangle[1].transform.position, triangle[2].transform.position, Color.yellow);
        Debug.DrawLine(triangle[2].transform.position, triangle[0].transform.position, Color.yellow);

        Vector3 a = point.transform.position - triangle[0].transform.position;
        Vector3 b = point.transform.position - triangle[1].transform.position;
        Vector3 c = point.transform.position - triangle[2].transform.position;

        Debug.DrawLine(point.transform.position, triangle[0].transform.position, Color.red);
        Debug.DrawLine(point.transform.position, triangle[1].transform.position, Color.red);
        Debug.DrawLine(point.transform.position, triangle[2].transform.position, Color.red);

        dot[0] = Vector3.Dot(a, b);
        dot[1] = Vector3.Dot(a, c);
        dot[2] = Vector3.Dot(b, c);

        Debug.LogError("dot[0]:" + dot[0]);
        Debug.LogError("dot[1]:" + dot[1]);
        Debug.LogError("dot[2]:" + dot[2]);

    }
}
