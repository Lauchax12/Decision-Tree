using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question_Node : Node
{
    public override void Execute(Citizen citizen)
    {
        switch (type)
        {
            
           
            case Questions.Qnigth:
                if (Enviroment.Instance.night == true)
                    trueNode.Execute(citizen);
                else
                    falseNode.Execute(citizen);
                break;
            case Questions.Qraining:
                if (Enviroment.Instance.rain == true)
                    trueNode.Execute(citizen);
                else
                    falseNode.Execute(citizen);
                break;
            case Questions.Qfood:
                if (Enviroment.Instance.food < 10)
                    trueNode.Execute(citizen);
                else
                    falseNode.Execute(citizen);
                break;

            case Questions.Qhunger:
                if (Enviroment.Instance.food < 5)
                    trueNode.Execute(citizen);
                else
                {
                    int randomdecition = Random.Range(0, 3);
                    print("decisión random " + randomdecition);
                    switch (randomdecition)
                    {
                        case 0:
                            print("conseguir madera");
                            falseNode.Execute(citizen);
                            break;
                        case 1:
                            print("conseguir comida");
                            falseNode2.Execute(citizen);
                            break;
                        default:
                            print("dormir");
                            falseNode3.Execute(citizen);
                            break;
                    }
                }
                break;
            case Questions.Qwood:
                if (Enviroment.Instance.wood < 10)
                    trueNode.Execute(citizen);
                else
                    falseNode.Execute(citizen);
                break;



        }
    }

    public Node trueNode;
    public Node falseNode;
    public Node falseNode2;
    public Node falseNode3;
    public Questions type;
    public enum Questions
    {
        Qfood, Qwood, Qnigth, Qraining, Qhunger
    }


}
