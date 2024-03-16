using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGeneraitor : MonoBehaviour
{
    public GameObject Ball;
    public GameObject Box;
    public GameObject Dimond;
    public GameObject Point;

    Vector3 lastCubePosition;


    void Start()
    {
        lastCubePosition = Point.transform.position;
    }


    void Update()
    {
        Generait();
    }

    private void Generait()
    {
        if (Vector3.Distance(Ball.transform.position, Point.transform.position) < 10)
        {
            for (int i = 0; i < 10; i++)
            {
                int x = Random.Range(0, 2);
                int z;
                //برای این که روی هم نیفتن
                if (x == 0)
                    z = 1;
                else
                    z = 0;

                lastCubePosition += new Vector3(x, 0, z);

                //برای ساخت زمبن
                GameObject lastCube = Instantiate(
                    Box,
                    lastCubePosition,
                    Quaternion.identity);

                //برای ساخت الماس های امتیاز
                if (2 >  Random.Range(0, 10))
                {
                    GenerateDimond(lastCubePosition);
                }

                if (i == 9)
                {
                    Point = lastCube;
                    Box = lastCube;
                }

            }
        }
    }

    void GenerateDimond(Vector3 location)
    {
        Instantiate(
            Dimond,
            location + new Vector3(0, 0.5f, 0),
            Quaternion.identity);
    }
}
