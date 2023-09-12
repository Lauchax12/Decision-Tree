using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Node : Node
{

    
    public override void Execute(Citizen citizen)
    {
        switch (type)
        {
           
            case TypeAction.ASleep:
                Debug.Log("A mimir");
                citizen.GoToSleep();
                break;
            case TypeAction.Afood:
                Debug.Log("conseguir comida");
                Enviroment.Instance.food++;
                citizen.GetFood();
                break;
            case TypeAction.Awood:
                Debug.Log("consigo madera");
                Enviroment.Instance.wood++;
                citizen.GetWood();
                break;
            case TypeAction.Ahouse:
                Debug.Log("construi casa");
                citizen.BuildHouses();
                break;
        }
    }

    public TypeAction type;

    public enum TypeAction
    {
        ASleep,
        Afood,
        Awood,
        Ahouse
    }



}
