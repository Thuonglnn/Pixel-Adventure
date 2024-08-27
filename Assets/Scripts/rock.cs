using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    public float right,left;
    private bool isRight;

    public float nhanh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {    var namX = transform.position.x;
        if(namX < left)
        {
           isRight = true; 
            
        }
        if(namX > right)
        {
            isRight = false;
        }

        if(isRight)
        {
            transform.Translate(new Vector3(Time.deltaTime * nhanh,0,0));
             Vector2 v = transform.localScale;
          v.x *=(v.x > 0) ? -1 : 1;
          transform.localScale = v;
        }
        else
        {
            transform.Translate(new Vector3(-Time.deltaTime * nhanh,0,0));
             Vector2 v = transform.localScale;
          v.x *=(v.x > 0) ? 1 : -1;
          transform.localScale = v;
        }
    }
}
