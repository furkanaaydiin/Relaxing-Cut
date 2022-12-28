using UnityEngine;

namespace Player
{
    public class PropellerBase : MonoBehaviour
    {
        
        public float PropellerSpeed;
        public float DirectionSpeed;
        public GameObject GamePropeller;
        
        public virtual void PropellerMove(Vector2 movementJoystickDirection)
        {
           // Debug.Log("base move " + gameObject.name);
        }

        public virtual void PropellerDirectionSpeed()
        {
            // GamePropeller.transform.rotation =  Quaternion.Euler(0,DirectionSpeed,0);
        }
        
        
        
        
        
    }
}
