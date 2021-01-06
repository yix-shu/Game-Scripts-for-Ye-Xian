using UnityEngine;
using System.Collections;
public class NPCMovement : MonoBehaviour{

  public float NPCSpeed;

  private RigidBody2D NPCRigidBody;

  public bool isMoving;
  public float moveTime;
  private float moveCounter;
  public float idleTime;
  private float idleCounter;
  private int walkDirection;

  void Start ()
  {
    NPCRigidBody = GetComponent<RigidBody2D>();

    idleCounter = idleTime;

    moveCounter = moveTime;

    ChooseDirection();
  }
  void Update ()
  {
    
  }
  public void ChooseDirection(){


  }
}