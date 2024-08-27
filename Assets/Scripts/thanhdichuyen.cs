using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thanhdichuyen : MonoBehaviour
{
    // Start is called before the first frame update
   public float right,left;
    private bool isRight;

    public float nhanh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    var thanhdichuyen = transform.position.x;
        if(thanhdichuyen < left)
        {
           isRight = true; 
            
        }
        if(thanhdichuyen > right)
        {
            isRight = false;
        }

        if(isRight)
        {
            transform.Translate(new Vector3(Time.deltaTime * nhanh,0,0));
          
        }
        else
        {
            transform.Translate(new Vector3(-Time.deltaTime * nhanh,0,0));
          
    }
}
}
