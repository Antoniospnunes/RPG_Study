using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    protected Player_Controller playerController;

    Ray lastRay;

    [SerializeField] protected Transform target;

    protected NavMeshAgent thisMesh;

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

        playerController.Click_Controller.Click.performed += _ => SelectClickedTarget();
    }

    void Update()
    {
        thisMesh.destination = target.position;

        Debug.DrawRay(lastRay.origin, lastRay.direction * 100);
    }

    private void SelectClickedTarget()
    {
        lastRay = Camera.main.ScreenPointToRay(playerController.Click_Controller.Mouse_Position.ReadValue<Vector2>());
    }
}