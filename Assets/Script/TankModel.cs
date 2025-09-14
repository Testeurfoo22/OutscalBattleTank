using Script;
using UnityEngine;

public class TankModel
{
    private TankController _tankController;
    
    public float MovementSpeed;
    public float RotationSpeed;
    
    public TankTypes TankType;
    public Material Color;

    public TankModel(TankSpawners.Tank tankData)
    {
        MovementSpeed = tankData.movementSpeed;
        RotationSpeed = tankData.rotationSpeed;
        TankType = tankData.type;
        Color = tankData.color;
    }

    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;
    }
}
