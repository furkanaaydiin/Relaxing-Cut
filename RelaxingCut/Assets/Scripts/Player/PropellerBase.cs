using UnityEngine;

namespace Player
{
    public class PropellerBase : MonoBehaviour
    {
        
        public float Speed;
        
        public virtual void Move(Vector2 movementJoystickDirection)
        {
            Debug.Log("base move " + gameObject.name);
          
        }
        
    }
}
