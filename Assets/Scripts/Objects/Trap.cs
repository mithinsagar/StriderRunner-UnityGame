// -----------------------------------------------------------------------------
// Strider Runner
// File   : Trap.cs
// Module : Trap
// Author : Mithin Sagar S
// GitHub : https://github.com/mithinsagar
// License: MIT (see LICENSE at project root)
// -----------------------------------------------------------------------------

using UnityEngine;

public class Trap : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerLife>().Die();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerLife>().Die();
        }
    }
}
