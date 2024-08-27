using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
     GameController g_c;
    // Start is called before the first frame update
    void Start()
    {
        g_c = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
   


     private void  OnCollisionEnter2D(Collision2D collision) 
     {
          if(collision.gameObject.CompareTag("Player"))
          {
          Debug.Log("va cham voi thanh base");
          g_c.tangDiem();
          Destroy(gameObject);
         }
     }


     private void OnTriggerEnter2D(Collider2D collision) {
         if(collision.CompareTag("DeadZone"))
         {
          Debug.Log("va cham voi DeadZone, GameOver");
          g_c.setTrangThai(true);
          Destroy(gameObject);
          }
     }


}
