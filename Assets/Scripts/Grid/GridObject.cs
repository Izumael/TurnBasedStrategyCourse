using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class GridObject 
{
    private GridPosition gridPosition;
    private GridSystem gridSystem;
    private List<Unit> unitList;

    public GridObject(GridSystem gridSystem, GridPosition gridPosition)
    {
        this.gridSystem = gridSystem;
        this.gridPosition = gridPosition;
        unitList = new List<Unit>();
    }

    //public string GetPosition() { 
    //    return gridPosition.ToString(); 
    //}

    public override string ToString()
    {
        string unitString = "";
        foreach (Unit unit in unitList)
        {
            unitString += unit.ToString() + "\n";
        }
        return gridPosition.ToString() + "\n" + unitString;
    }

    public void AddUnit(Unit unit)
    {
        this.unitList.Add(unit);
    }

    public void RemoveUnit(Unit unit)
    {
        this.unitList.Remove(unit);
    }

    public List<Unit> GetUnitList()
    {
        return this.unitList;
    }

    public bool HasAnyUnit()
    {
        return unitList.Count > 0;
    }
}
