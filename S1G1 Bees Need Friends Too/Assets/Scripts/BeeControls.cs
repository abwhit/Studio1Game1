using UnityEngine;
using System.Collections;

public class BeeControls : MonoBehaviour {

    // Store all the movement variables in floats
    public float speed = 0f;
    private float horiMovement = 0f;
    private float vertMovement = 0f;
    // Link the rigidBody of this gameObject
    private Rigidbody2D RB;
    // Bool to change the control scheme
    public bool bee1 = false;

    //public Collectable collectables;

    public GameController gameController;

    public GameObject otherBee;

    public float distance;


    void Awake()
    {
        // Get the rigidBody component of this gameObject
        RB = GetComponent<Rigidbody2D>();

        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        distance = Vector2.Distance(transform.position, otherBee.transform.position);

        DistanceCheck();


        

	
	}

    void FixedUpdate()
    {
        // Check which bee is is and alter the controls accordingly
        if (bee1)
        {
            // Store the axis in the floats created above
            horiMovement = Input.GetAxis("Horizontal");
            vertMovement = Input.GetAxis("Vertical");
        }
        else
        {
            horiMovement = Input.GetAxis("Horizontal2");
            vertMovement = Input.GetAxis("Vertical2");
        }
        // Change the velocity of the object using the speed and movement floats
        RB.velocity = new Vector2(horiMovement * speed, vertMovement * speed);

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("111");
        if (other.gameObject.tag == "Collectable")
        {
            if (other.gameObject.GetComponent<Collectable>().IsCollectable)
            {
                gameController.score += other.gameObject.GetComponent<Collectable>().scoreIncrease;
                Destroy(other.gameObject);
                Debug.Log("111");
            }


        }

    }

   

    void DistanceCheck()
    {
        if (distance <= 2f)
        {
            gameController.beesAreClose = true;
        }
        else
        {
            gameController.beesAreClose = false;
        }

    }


}
