using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseCollider : MonoBehaviour
{
    public int LoseCounter = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LoseCounter++;
        if (LoseCounter > 1)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
