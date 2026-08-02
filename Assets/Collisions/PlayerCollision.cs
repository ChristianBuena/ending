using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        String Player = collision.gameObject.tag;

        switch (Player)
        {

        }

    }
}
