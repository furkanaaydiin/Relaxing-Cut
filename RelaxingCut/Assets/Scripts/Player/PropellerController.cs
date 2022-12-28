using System;
using UnityEngine;

namespace Player
{
    public class PropellerController : PropellerBase
    {
        public static PropellerController Instance;
        
        private void Awake()
        {
            Instance = this;
        }

        public override void PropellerMove(Vector2 movementJoystickDirection)
        {
            base.PropellerMove(movementJoystickDirection);
            var localPosition = transform.localPosition;
            localPosition = Vector3.Lerp(localPosition,
                localPosition + new Vector3(movementJoystickDirection.x, 0, movementJoystickDirection.y),
                Time.deltaTime * PropellerSpeed);
            transform.localPosition = localPosition;
        }

        public override void PropellerDirectionSpeed( )
        {
            base.PropellerDirectionSpeed();
            GamePropeller.transform.Rotate(DirectionSpeed,0,0);
        }
    }
    
    
    
}
