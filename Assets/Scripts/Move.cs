using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public void MoveUp() 
    {
        transform.Translate(0f, 0f, 0.5f);
    }

    public void MoveDown()
    {
        transform.Translate(0f, 0f, -0.5f);
    }
    public void MoveLeft()
    {
        transform.Translate(-0.5f, 0f, 0f);
    }
    public void MoveRight()
    {
        transform.Translate(0.5f, 0f, 0f);
    }


}
