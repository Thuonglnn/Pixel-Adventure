using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float tocdo = 5.0f;
    public float lucnhay =500f;
    public Animator animator;
    bool isRight;
    bool chamnen;

    public GameObject pannel , relay , Gameover , pause , pannel1 , GameWin, Exit;
public Text youpoint;
public Text diemText;
int tong = 0;




public GameObject PSBrick;

public void tinhTong(int score)
{
  tong += score;
  diemText.text = "Điểm : " + tong;
  youpoint.text = "Tổng Điểm : " + tong;
}





public AudioSource nhacchet;
public AudioSource nhactien;
public AudioSource nhacnen;
public AudioSource nhachop_quai;




    // Start is called before the first frame update
    void Start()
    {
      nhacnen.Play();
      nhacnen.loop = true;
      nhacchet.Stop();
nhactien.Stop();
nhachop_quai.Stop();
     animator = GetComponent<Animator>();   
     tinhTong(0);
    }

    // Update is called once per frame
    void Update()
    { 
       animator.SetBool("isRunning",false);
       
       

        if(Input.GetKey(KeyCode.RightArrow))
        {
          isRight = true;
          
            animator.SetBool("isRunning",true);
          transform.Translate(Time.deltaTime * tocdo,0,0);
          Vector2 v = transform.localScale;
          v.x *=(v.x > 0) ? 1 : -1;
          transform.localScale = v;
        }


        if(Input.GetKey(KeyCode.LeftArrow))
        {
          isRight = false;
          
            animator.SetBool("isRunning",true);
          transform.Translate(Time.deltaTime * -tocdo,0,0);
           Vector2 v = transform.localScale;
          v.x *=(v.x > 0) ? -1 : 1;
          transform.localScale = v;
        }



      if(Input.GetKey(KeyCode.UpArrow))
        { 
          
         
            if(chamnen == true)
            {  
          if(isRight ==true)
         {
           
          transform.Translate(Time.deltaTime * tocdo, Time.deltaTime * lucnhay,0);
           Vector2 v = transform.localScale;
          v.x *=(v.x > 0) ? 1 : -1;
          transform.localScale = v;
         }
         else
         {   
          transform.Translate(Time.deltaTime * -tocdo, Time.deltaTime * lucnhay,0);
           Vector2 v = transform.localScale;
          v.x *=(v.x > 0) ? -1 : 1;
          transform.localScale = v;
         }   

          chamnen = false;

            }
        
        }

    }

     
   public void OnCollisionEnter2D(Collision2D collision)
   {
    if(collision.gameObject.CompareTag("nen"))
    {
        chamnen = true;
        Debug.Log(chamnen);
    }


   
  

   }

   public void  OnTriggerEnter2D(Collider2D other) 
   {
     if(other.gameObject.tag == "tren")
     { nhachop_quai.Play();

        var name = other.attachedRigidbody.name;
        Destroy(GameObject.Find(name));
     }
      if(other.gameObject.tag == "trai")
     { nhacnen.Stop();
      nhacchet.Play();
      Time.timeScale = 0;
      pannel.SetActive(true);
      relay.SetActive(true);
      Gameover.SetActive(true);
      
      pause.SetActive(true);
      Exit.SetActive(true);
      
     }


      if(other.gameObject.tag == "win")
     {
      

      Time.timeScale = 0;
    pannel1.SetActive(true);
      relay.SetActive(true);
      
      
      pause.SetActive(true);
      
      GameWin.SetActive(true);
      Exit.SetActive(true);
     }


   if(other.gameObject.tag == "coin")
   {
   
    nhactien.Play();
    var name = other.attachedRigidbody.name;
    Destroy(GameObject.Find(name));
    tinhTong(1);
   }

   if(other.gameObject.tag == "brick")
   {
    nhachop_quai.Play();
    var name = other.attachedRigidbody.name;
    Destroy(GameObject.Find(name));

    Instantiate(PSBrick,
                other.gameObject.transform.position,
                other.gameObject.transform.localRotation);
                tinhTong(5);
   }
 if(other.gameObject.tag == "qua_man")
    {
     SceneManager.LoadScene("Man_3_2");
     Time.timeScale = 1;
    }
    
   }
}