using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject1 : MonoBehaviour
{
    
    public GameObject  Bucket, Flower;
    private GameObject currentObject;
    private GameObject CurrentObject
    {
         get
        {
            if(currentObject == null)
            {
                currentObject = Bucket;
            }

            return currentObject;
        }
         set
        {
            currentObject = value;
        }
    }
  private enum Axes
    {
        xTrans,
        zTrans,
        yTrans,
        yRot
    }
    private Axes Curaxe = Axes.xTrans;

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
   

    void Update()
    {
        // To change betwin 2 objects 
        if (Input.GetKeyDown(KeyCode.A))
        {
            ChangeCurrentObject();
            Debug.Log(CurrentObject);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
            ChangeCurrentAxe(Axes.xTrans);

       

        if (Input.GetKeyDown(KeyCode.LeftArrow))
           ChangeCurrentAxe(Axes.zTrans);

       

        if (Input.GetKeyDown(KeyCode.E))
            ChangeCurrentAxe(Axes.yTrans);

       


        if (Input.GetKeyDown(KeyCode.Z))
            ChangeCurrentAxe(Axes.yRot);

        if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
            
            IncreaseAxe();
        }

        if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {

            DecreaseAxe();
        }

    }

    void ChangeCurrentObject()
    {
       
         if (CurrentObject = Flower)
        {
            CurrentObject = Bucket;
        }
        else if (CurrentObject = Bucket)
        {
            CurrentObject = Flower;
        }


    }

    void ChangeCurrentAxe(Axes axe)
    {
        Curaxe = axe;

    }

    void IncreaseAxe()
    {
        switch (Curaxe)
        {
            case Axes.xTrans:
                CurrentObject.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                break;
               
            case Axes.zTrans:
                CurrentObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                break;
               
            case Axes.yTrans:
                CurrentObject.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                break;
                
            case Axes.yRot:
                CurrentObject.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
                break;
        }
    }
    void DecreaseAxe()
    {
        switch (Curaxe)
        {
            case Axes.xTrans:
                CurrentObject.transform.Translate(Vector3.forward * -moveSpeed * Time.deltaTime);
                break;

            case Axes.zTrans:
                CurrentObject.transform.Translate(Vector3.left * -moveSpeed * Time.deltaTime);
                break;

            case Axes.yTrans:
                CurrentObject.transform.Translate(Vector3.up * -moveSpeed * Time.deltaTime);
                break;

            case Axes.yRot:
                CurrentObject.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
                break;
        }
    }
}
