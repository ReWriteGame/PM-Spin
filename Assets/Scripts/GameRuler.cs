using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private Arrow arrow2;
    [SerializeField] private ScoreCounter scoreCounter;




    public UnityEvent arrowCoincidedEvent;
    public UnityEvent arrowNotCoincidedEvent;

    public bool checkCells()
    {
        return arrow1.collidedObject.GetComponent<Cell>().ID == arrow2.collidedObject.GetComponent<Cell>().ID;
    }

    public void countScore()
    {
        if (checkCells())
        {
            if (arrow1.collidedObject.GetComponent<Cell>().Value >= 0)
                scoreCounter.add(arrow1.collidedObject.GetComponent<Cell>().Value);
            else scoreCounter.takeAway(-arrow1.collidedObject.GetComponent<Cell>().Value);

            if (arrow2.collidedObject.GetComponent<Cell>().Value >= 0)
                scoreCounter.add(arrow2.collidedObject.GetComponent<Cell>().Value);
            else scoreCounter.takeAway(-arrow2.collidedObject.GetComponent<Cell>().Value);
        }
    }
}
