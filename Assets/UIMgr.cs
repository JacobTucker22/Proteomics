using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIMgr : MonoBehaviour
{

     public static UIMgr inst;
     public Text[] acidLabels;
     public Text[] acidCounts;


     // Start is called before the first frame update
     void Start()
    {
          inst = this;
     }

    // Update is called once per frame
    void Update()
    {
          int i = 0;
          foreach (AcidCount entry in AcidMgr.inst.counts)
          {
               acidLabels[i].text = entry.type;
               acidCounts[i].text = entry.count.ToString();
               i++;
          }

     }
}
