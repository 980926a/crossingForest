﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public GameManager manager;
    
    void Update()
    {
        if (!Input.GetButton("Vertical"))
        {
            Debug.Log("!");
            //while(true)
            //{
                this.transform.Translate(new Vector3(0, 0, 0.007f));
            //}
        }    //transform.Translate(0, 0.1f, 0);
        else
        {
            //Debug.Log(transform.position.z - target.position.z);

            if (transform.position.z - target.position.z > offset.z)
                this.transform.Translate(new Vector3(0, 0, 0.007f));
            else
                transform.position = new Vector3(transform.position.x, transform.position.y, target.position.z + offset.z);
                //target.position + offset;
            //StartCoroutine(moveCamera());
        }
        
        if (transform.position.z > target.position.z && manager.isStart)
            manager.GameOver();

            
    }

    // IEnumerator moveCamera()
    // {
    //     if(target.position.z - transform.position.z > offset.z)
    //     {
    //         this.transform.Translate(new Vector3(0, 0, 0.01f));
    //         yield return new WaitForSeconds(0.01f);
    //     }
    //     transform.position = target.position + offset;
    // }
}