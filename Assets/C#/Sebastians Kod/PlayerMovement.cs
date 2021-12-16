/* Player Movement
* Av Sebastian
*/

//(PhotonView.isMine)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode jump;
    public KeyCode interact;
    public Vector2 JumpHeight;
    private Rigidbody2D rb;
    public bool isActive = true;
    
    bool isgrounded;

    public int moveSpeed;

    public float enableMovementTime;

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

            rb.velocity = new Vector2(horz * moveSpeed * Time.fixedDeltaTime, rb.velocity.y); //Kallar hit rb via velocity. Sätter sedan bestämda hastigheten med (horz * x)
            
            if (Mathf.Abs( rb.velocity.y) <0.05f)
            {
                isgrounded = true;
            }

            //Får Tom att hoppa
            if (Input.GetKeyDown(jump) && isgrounded)
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
        yield return new WaitForSeconds(enableMovementTime);
        isActive = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Om dessa kriterier möts gör Move() koden sitt jobb.
        if (collision.GetComponent<IBtn>() != null && Input.GetKey(KeyCode.E))
        {
            collision.GetComponent<IBtn>().Btn();
        }
    }
}
