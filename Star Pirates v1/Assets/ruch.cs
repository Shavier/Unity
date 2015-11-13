using UnityEngine;
using System.Collections;

public class ruch : MonoBehaviour {

    public float moveSpeed = 2f;
    public Vector2 speed = new Vector2(10, 10);
    Rigidbody2D rigid;
    private Vector2 movement;



    void Start () {
        rigid = GetComponent<Rigidbody2D>();
    }
	

	void Update () {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        movement = new Vector2(
            speed.x * inputX,
            speed.y * inputY
            );

    }

    void FixedUpdate()
    {
        rigid.velocity = movement;
    }
}
