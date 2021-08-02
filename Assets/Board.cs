using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public float RotSpeed = 20;


    void OnMouseDrag()
    {
    	turn.x = Input.GetAxis("Mouse X");
    	turn.y = Input.GetAxis("Mouse Y")*RotSpeed*Mathf.Deg2Rad;
    
    	transform.Rotate(Vector3.up, -rotX);
    	transform.Rotate(Vector3.right, rotY);
    }
}