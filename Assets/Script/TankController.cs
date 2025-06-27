using UnityEngine;

public class TankController
{
    private TankModel _tankModel;
    private TankViewer _tankViewer;

    public TankController(TankModel tankModel, TankViewer tankViewer, GameObject Spawn)
    {
        _tankModel = tankModel;
        _tankViewer = tankViewer;
        _tankModel.SetTankController(this);
        _tankViewer.SetTankController(this);
        
        GameObject tank = GameObject.Instantiate(_tankViewer.gameObject);
        tank.transform.position = Spawn.transform.position;
        tank.transform.rotation = Spawn.transform.rotation;
    }
}
