using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    enum DoorState { Open, Close}; //Kuin boolean, mutta voi sisältää enemmän kuin 2 vaihtoehtoa.
    DoorState state = DoorState.Close;

    public Transform endMarker;
    public float moveSpeed = 1f;
    private Vector3 startPoint;
    private bool isMoving = false;
    private Vector3 endPoint;

    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.position;
        endPoint = endMarker.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving == true)
        {
            switch (state)
            {
                case DoorState.Close:
                    if ()
                    {

                    }
                    else
                    {

                    }

                case DoorState.Open:
                    if ()
                    {

                    }
                    else
                    {

                    }

            }
        }
    }
}
