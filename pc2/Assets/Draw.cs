using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    private Vector3 int_pos;
    private float radius =2f;

    void start(){
        int_pos = transform.position;
    }

   void OnDrawGizmos(){
       Gizmos.color=Color.cyan;
       Gizmos.DrawWireSphere(int_pos, radius);
   }
}
