using Script;
using UnityEngine;

public class TankModel
{
    private TankController _tankController;
    
    public float MovementSpeed;
    public float RotationSpeed;
    
    public TankTypes TankType;
    public Material Color;

    public TankModel(Tank tankData)
    {
        MovementSpeed = tankData.MovementSpeed;
        RotationSpeed = tankData.RotationSpeed;
        TankType = tankData.Type;
        Color = tankData.Color;
    }

    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;
    }
}
