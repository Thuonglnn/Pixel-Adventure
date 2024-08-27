using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;
    public float start;
    public float end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float player_x = player.transform.position.x;
      float cam_x = transform.position.x;

      if(player_x > start && player_x < end)
      cam_x = player_x;
      else 
      {
        if(player_x < start)
        cam_x = start;
        if(player_x > end)
        cam_x = end;
      }
      transform.position = new Vector3(
                                       cam_x,
                                       transform.position.y,
                                       transform.position.z
       );
    }
 
}