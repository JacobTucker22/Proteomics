using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public PlayerController mPlayer;
     public GameObject catcher;
     public Vector3 position;

     private void Awake()
     {
          mPlayer = this;
     }

     // Start is called before the first frame update
     void Start()
    {
          position = catcher.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
          Vector3 mouse = Input.mousePosition;
          position.x = Camera.main.ScreenToWorldPoint(mouse).x;

          catcher.transform.position = position;

    }
}
