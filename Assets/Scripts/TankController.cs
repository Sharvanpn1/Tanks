//using System.Numerics;
//using System.Diagnostics;
using UnityEngine;

public class TankController
{
    private TankModel tankModel;

    private TankView tankView;

    private Rigidbody rb;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;

        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetRigidbody();

        tankView.SetTankController(this);

        tankModel.SetTankController(this);
        tankView.ChangeColor(tankModel.color);

    }

    public void Move(float movement, float movementSpeed)
    {
        //Debug.Log(rb);
        rb.velocity = tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate, float rotateSpeed)
    {
        // Debug.Log(rb);
        Vector3 vector = new Vector3(0f, rotate * rotateSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);

    }
    public TankModel GetTankModel()
    {
        return tankModel;

    }




}
