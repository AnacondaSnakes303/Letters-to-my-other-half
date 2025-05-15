using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class CollisionController : MonoBehaviour
{
    public GameObject Winner;
    
  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.name == "door")
    {
        Debug.Log("enter");
    }
  }
  private void  OnCollisionStay2D(Collision2D collision)
  {
   if (collision.gameObject.name == "door")
   {
        Debug.Log("stay");
    }
  }
  private void OncollisionExit2D(Collision2D collision)
  {
   if (collision.gameObject.name == "door")
    {
        Debug.Log("exit");
    }
  }
}