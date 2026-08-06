// -----------------------------------------------------------------------------
// Strider Runner
// File   : Checkpoint.cs
// Module : Checkpoint
// Author : Mithin Sagar S
// GitHub : https://github.com/mithinsagar
// License: MIT (see LICENSE at project root)
// -----------------------------------------------------------------------------

using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Collider2D checkpointCollider;
    private static readonly int onCompleteAnim = Animator.StringToHash("OnComplete");

    void Awake()
    {
        if (animator == null)
            animator = GetComponent<Animator>();

        if (checkpointCollider == null)
            checkpointCollider = GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GetComponentInParent<CheckpointManager>().SetLatestCheckpoint(transform);
            AudioManager.Instance.PlaySound(AudioType.checkpointPass);
            animator.SetTrigger(onCompleteAnim);
            checkpointCollider.enabled = false;
        }
    }
}
