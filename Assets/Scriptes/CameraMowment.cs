using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMowment : MonoBehaviour
{
   public Transform target;
   public Vector3 offset = new Vector3(0, 0, -10);

   private void Update()
   {
      transform.position = target.position + offset;
   }
}
