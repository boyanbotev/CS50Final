using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<MoveEnemy>() != null)
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
    }
}
