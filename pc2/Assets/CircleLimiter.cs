using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleLimiter : MonoBehaviour
{
  [SerializeField]
    [Range(1, 20)]
    private int radius;
    

    public Transform Target;
    [SerializeField]
    private Transform Follower;

    private void Awake()
    {
    }

    //otra opcion de circulo oculta en unity

    private void Update()
    {
        Vector3 centerPosition = transform.localPosition;
         float distance = Vector3.Distance(Target.transform.position, centerPosition);

         if (distance > radius) 
    {
      Vector3 fromOriginToObject = Target.transform.position - centerPosition; 
      fromOriginToObject *= radius / distance; 
      Target.transform.position = centerPosition + fromOriginToObject; 
 }

      
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position,radius);
    }
}
