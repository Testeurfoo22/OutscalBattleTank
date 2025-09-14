using UnityEngine;

public class TankModel
{
    private TankController _tankController;
    
    public float MovementSpeed;
    public float RotationSpeed;

    public TankModel(float movementSpeed, float rotationSpeed)
    {
        MovementSpeed = movementSpeed;
        RotationSpeed = rotationSpeed;
    }

    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;
    }
}
