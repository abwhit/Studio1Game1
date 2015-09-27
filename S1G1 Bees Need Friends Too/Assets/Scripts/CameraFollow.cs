using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform bee1;
    public Transform bee2;

    public float x1;
    public float y1;
    public float x2;
    public float y2;

    public float middleOfX;
    public float middleOfY;

    public float newX;
    public float newY;



	// Use this for initialization
	void Start () {

        


    }
	
	// Update is called once per frame
	void Update () {

        x1 = bee1.position.x;
        y1 = bee1.position.y;
        x2 = bee2.position.x;
        y2 = bee2.position.y;

        middleOfX = ((x2 -= x1) / 2);
        middleOfY = ((y2 -= y1) / 2);

        newX = middleOfX + x1;
        newY = middleOfY + y1;


        
        transform.position = new Vector3(newX, newY, -10);


    }
}
