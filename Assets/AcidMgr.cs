using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidMgr : MonoBehaviour
{
     public static AcidMgr inst;
     public GameObject[] acids;
     public List<AcidCount> counts;


     // Start is called before the first frame update
     void Start()
    {
          inst = this;
          AcidCount temp = new AcidCount();
          temp.type = "A";
          temp.count = 2;
          counts.Add(temp);
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
