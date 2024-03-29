using UnityEngine;

namespace Player
{
    public class InputController : MonoBehaviour
    {
        public void SetInput(Vector2 movementJoystickDirection)
        {
            PropellerController.Instance.PropellerMove(movementJoystickDirection);
            PropellerController.Instance.PropellerDirectionSpeed();
        }
    }
}
