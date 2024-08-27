using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
     public float tocdo=20;
         float huong_x;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        huong_x = Input.GetAxisRaw("Horizontal");
        float buoc_di_chuyen = huong_x * tocdo * Time.deltaTime;
        Vector3 vitrimoi = new Vector3(buoc_di_chuyen,0,0);

        if((transform.position.x < -9.2 && huong_x <0)||
        (transform.position.x > 9.2 && huong_x >0))
        return;

        transform.position += vitrimoi;
      
    }
}
