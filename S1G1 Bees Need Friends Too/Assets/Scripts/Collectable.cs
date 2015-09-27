using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {



    public int scoreIncrease;

    public int numAssociation;

    public GameController gameController;

    public GameObject sprite;

    public bool IsCollectable;

    public Collider2D Coll;

    void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        Coll = GetComponent<Collider2D>();


    }

    void Start()
    {
        IsCollectable = true;


    }

    void Update()
    {
       
     if(numAssociation > 1)
        {
            if(gameController.beesAreClose)
            {
                sprite.SetActive(true);
                IsCollectable = true;
                Coll.enabled = true;

            }
            else
            {

                sprite.SetActive(false);
                IsCollectable = false;
                Coll.enabled = false;

            }

        }
      

    }

    void CheckBees()
    {
        if(gameController.beesAreClose)
        {
            gameObject.SetActive(true);

        }
        else
        {
            gameObject.SetActive(false);
        }
       
      

    }


}
