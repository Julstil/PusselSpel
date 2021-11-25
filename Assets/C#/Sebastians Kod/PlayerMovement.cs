/* Player Movement
* Av Sebastian
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 JumpHeight;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Kallar hit Tom
    }
    void Update()
    {
        //Får Tom att röra på sig
        float horz = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(horz * 700 * Time.deltaTime, rb.velocity.y); //Kallar hit rb via velocity. Sätter sedan bestämda hastigheten med (horz * x)

        //Får Tom att hoppa
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(JumpHeight, ForceMode2D.Impulse);
        }
    }
}
