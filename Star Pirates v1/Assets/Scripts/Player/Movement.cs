using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float movementSpeed = 2f;
    public Vector2 speed = new Vector2(10, 10);
	private int test = 3; 
    Rigidbody2D rigid;
	string tekst;

    void Start () {


        rigid = GetComponent<Rigidbody2D>();

    }



    private Vector2 movement;

    public Vector3 direction { get; internal set; }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

//A ja sobie kurwa tutaj dodam		
		
        movement = new Vector2(
          speed.x * inputX,
          speed.y * inputY);
//a coś sobie tutaj dodam
test = 1;

        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");
        // Careful: For Mac users, ctrl + arrow is a bad idea

    }

    void FixedUpdate()
    {
        // 5 - Move the game object
        rigid.velocity = movement;
        //rigidbody2D.velocity = movement;
		tekst = "ala";
    }
}
