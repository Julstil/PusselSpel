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
    public bool isActive = true;
    
    bool isgrounded;
    public GameObject feet;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Kallar hit Tom
    }
    void Update()
    {
        if (isActive)
        {
            //Får Tom att röra på sig
            float horz = Input.GetAxis("Horizontal");

            rb.velocity = new Vector2(horz * 700 * Time.deltaTime, rb.velocity.y); //Kallar hit rb via velocity. Sätter sedan bestämda hastigheten med (horz * x)
            if (Mathf.Abs( rb.velocity.y) <0.05f)
            {
                isgrounded = true;
            }
            //Får Tom att hoppa
            if (Input.GetKeyDown(KeyCode.Space) && isgrounded)
            {
                rb.AddForce(JumpHeight, ForceMode2D.Impulse);
                isgrounded = false;
            }
        }
    }

    public void Reenable()
    {
        StartCoroutine(ReenableCoroutine());
    }
    public IEnumerator ReenableCoroutine()
    {
        yield return new WaitForSeconds(2);
        isActive = true;
    }
}
