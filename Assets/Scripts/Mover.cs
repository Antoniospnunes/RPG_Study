using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    protected Player_Controller playerController;

    protected Ray lastRay;

    [SerializeField] protected Transform target;

    protected NavMeshAgent thisMesh;

    [SerializeField] protected Animator animator;

    [SerializeField] protected float currentVelocity;
    protected Vector3 localVelocity;

    protected bool isHoldingToMove;

    private void Awake()
    {
        playerController = new Player_Controller();
    }

    protected void OnEnable()
    {
        playerController.Enable();
    }

    protected void OnDisable()
    {
        playerController.Disable();
    }

    void Start()
    {
        thisMesh = GetComponent<NavMeshAgent>();

        playerController.Click_Controller.SelectDestination.performed += _ => StartSelectingTarget();
        playerController.Click_Controller.SelectDestination.canceled += _ => StopSelectingTarget();
    }

    void Update()
    {
        Debug.DrawRay(lastRay.origin, lastRay.direction * 100);

        UpdateAnimator();

        if (isHoldingToMove)
        {
            MoveToTarget();
        }
    }

    private void StartSelectingTarget()
    {
        isHoldingToMove = true;
    }

    private void StopSelectingTarget()
    {
        isHoldingToMove = false;
    }

    private void MoveToTarget()
    {
        lastRay = Camera.main.ScreenPointToRay(playerController.Click_Controller.Mouse_Position.ReadValue<Vector2>());
        RaycastHit hitInfo;

        if (Physics.Raycast(lastRay, out hitInfo))
        {
            thisMesh.destination = hitInfo.point;
        }
    }

    private void UpdateAnimator()
    {
        localVelocity = transform.InverseTransformDirection(thisMesh.velocity);

        if (currentVelocity != Mathf.Abs(localVelocity.z));
        {
            currentVelocity = Mathf.Abs(localVelocity.z);

            animator.SetFloat("ForwardSpeed", currentVelocity);
        }
    }
}
