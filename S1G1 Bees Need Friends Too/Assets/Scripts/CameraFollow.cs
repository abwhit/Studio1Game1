using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    // Storing both of the bees positions
    public Transform bee1;
    public Transform bee2;

    // Storing the x and y coordinates for the bees
    public float x1;
    public float y1;
    public float x2;
    public float y2;

    // Store the z position so it can be used later to get the camera position
    float zPos = -10f;

    // Storing the x and y coords which are in between the entities
    public float middleOfX;
    public float middleOfY;

    // Storing the new position of the camera
    public float newX;
    public float newY;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        // Find the x and y positions as the game progresses
        x1 = bee1.position.x;
        y1 = bee1.position.y;
        x2 = bee2.position.x;
        y2 = bee2.position.y;
        // Find the middle of the entities
        middleOfX = ((x2 -= x1) / 2);
        middleOfY = ((y2 -= y1) / 2);
        // Find the new x and y positions
        newX = middleOfX + x1;
        newY = middleOfY + y1;
        // Move to that new position
        transform.position = new Vector3(newX, newY, -10);


    }
}
