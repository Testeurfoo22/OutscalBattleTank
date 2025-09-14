using UnityEngine;

public class TankController
{
    private TankModel _tankModel;
    private TankViewer _tankViewer;
    
    private Rigidbody _rb;

    public TankController(TankModel tankModel, TankViewer tankViewer, GameObject spawn)
    {
        _tankModel = tankModel;
        _tankViewer = Object.Instantiate(tankViewer, spawn.transform.position, spawn.transform.rotation);
        _tankModel.SetTankController(this);
        _tankViewer.SetTankController(this);

        _rb = _tankViewer.GetRigidBody();
    }

    public void Move(float movement, float movementSpeed)
    {
        _rb.velocity = _tankViewer.transform.forward * movementSpeed * movement;
    }

    public void Rotate(float rotation, float rotationSpeed)
    {
        Vector3 vector = new Vector3(0f, rotation * rotationSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        _rb.MoveRotation(_rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return _tankModel;
    }
}
