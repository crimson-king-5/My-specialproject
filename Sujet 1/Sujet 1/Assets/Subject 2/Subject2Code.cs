using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject2Code : MonoBehaviour
{
    public GameObject Cube1;
    public GameObject Cube2;
    public float Distance_;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Distance_ = Vector3.Distance(Cube1.transform.position, Cube2.transform.position);

 
    }
}
