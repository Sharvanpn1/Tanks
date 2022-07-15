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

    }

    public void Move(float movement, float movementSpeed)
    {

    }

    public void Rotate(float rotate, float rotateSpeed)
    {

    }
}
