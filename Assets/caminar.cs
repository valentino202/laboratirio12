using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caminar : MonoBehaviour
{
    private Rigidbody2D componenRigibodi2D;
    private float horizontal;
    private float vertical;
    public float speedX;
    public float speedY;
    private void Awake()
    {
        
        componenRigibodi2D = GetComponent<Rigidbody2D>();   
    }
    void Start()
    {
        
    }
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {

        componenRigibodi2D.velocity = new Vector2(horizontal * speedX, vertical * speedY);
    }
}
