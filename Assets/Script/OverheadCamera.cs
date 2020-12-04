using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverheadCamera : MonoBehaviour
{
    public GameObject TargetBowlingBall;
    public float maximumRailLenght;
    Transform targetTransform;
    // Start is called before the first frame update
    void Start()
    {
        targetTransform = TargetBowlingBall.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = targetTransform.position;
        targetPos.z -= 1.2f;
        Debug.Log(targetPos.z);
        if (targetPos.z > maximumRailLenght)
            targetPos.z = maximumRailLenght;

        Vector3 NewPos = GetComponent<Transform>().position;
        NewPos.z = targetPos.z;
        GetComponent<Transform>().position = NewPos;
    }
}

//private void ReleaseObject()
//{
//    // 1if (GetComponent<FixedJoint>())
//    {
//        // 2
//        GetComponent<FixedJoint>().connectedBody = null;
//        Destroy(GetComponent<FixedJoint>());
//        // 3
//        objectInHand.GetComponent<Rigidbody>().velocity = controllerPose.GetVelocity();
//        objectInHand.GetComponent<Rigidbody>().angularVelocity = controllerPose.GetAngularVelocity();

//    }
//    // 4
//    objectInHand = null;
//}