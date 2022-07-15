//using System.Numerics;
//using System.Threading.Tasks.Dataflow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel();

        TankController tankController = new TankController(tankModel, tankView);

        //TankController tankController = new TankController(tankModel, tankView);
    }

}
