using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankViewer : MonoBehaviour
{
    
    private TankController _tankController;
    
    public Rigidbody rb;
    public MeshRenderer[] mRChilds;

    private float _movement;
    private float _rotation;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        TankSpawners tankSpawners = FindObjectOfType<TankSpawners>();
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform, false);
        cam.transform.localPosition = tankSpawners.camPosition;
        cam.transform.localRotation = Quaternion.Euler(tankSpawners.camRotation);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (_movement != 0) { _tankController.Move(_movement, _tankController.GetTankModel().MovementSpeed); }
        if (_rotation != 0) { _tankController.Rotate(_rotation, _tankController.GetTankModel().RotationSpeed); }
    }

    private void Movement()
    {
        _movement = Input.GetAxis("Vertical");
        _rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;
    }

    public Rigidbody GetRigidBody()
    {
        return rb;
    }

    public void ChangeColor(Material color)
    {
        foreach (var mRChild in mRChilds)
        {
            mRChild.material = color;
        }
    }
}
