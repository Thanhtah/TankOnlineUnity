using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public int Money { get; set; }
    
    public TankType SelectedTank;
    public List<TankType> AvailableTank = new List<TankType>() ;

    private static Inventory instance;

    public static Inventory GetInstance()
    {
        if (instance == null)
        {
            instance = new Inventory();
        }
        return instance;
    }

    private Inventory()
    {
        Money = 10000;
        SelectedTank = TankType.Default;
        AvailableTank.Add(TankType.Default);
    }

    public void AddTank(TankType type)
    {
        if (!FindTank(type))
        {
            AvailableTank.Add(type);
        }
    }

    public bool FindTank(TankType tank)
    {
        return AvailableTank.Contains(tank);
    }
}
