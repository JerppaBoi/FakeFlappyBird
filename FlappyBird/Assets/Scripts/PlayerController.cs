using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Components:
    private Rigidbody2D rb;

    // Variables:
    [SerializeField] private float power;
    private float defaultGravity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultGravity = rb.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale = 0;

            rb.AddForce(Vector2.up * power);

            rb.gravityScale = defaultGravity;
            Debug.Log("Space");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }
}
