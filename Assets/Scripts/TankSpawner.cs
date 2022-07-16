//using System.Numerics;
//using System.Threading.Tasks.Dataflow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankTypes;
        public Material color;

    }
    public List<Tank> tankList;
    public TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        //CreateTank();
    }

    public void CreateTank(TankTypes tankType)
    {
        int i;
        if (tankType == TankTypes.BlueTank)
            i = 1;
        else if (tankType == TankTypes.GreenTank)
            i = 0;
        else
            i = 2;
        TankModel tankModel = new TankModel(tankList[i].movementSpeed, tankList[i].rotationSpeed, tankList[i].tankTypes, tankList[i].color);

        TankController tankController = new TankController(tankModel, tankView);

        //TankController tankController = new TankController(tankModel, tankView);
    }

}
