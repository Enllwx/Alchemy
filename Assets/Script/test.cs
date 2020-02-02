using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 public class EnumTest : MonoBehaviour {
   public enum MyDays {
         Sunday,
         Monday,
         Tuesday,
         Wednesday,
         Thursday,
         Friday,
         Saturday,
     };
     //show in inspector
     public MyDays days;
     // Use this for initialization
     void Start () {
     }
     
     // Update is called once per frame
     void Update () {
         switch (days) {
         case (MyDays.Sunday):
             Debug.Log ("Today is Sunday");
             break;
         case(MyDays.Monday): 
             Debug.Log ("Today is Monday");
             break;
             //etc...
         }
         
     }
 }
 