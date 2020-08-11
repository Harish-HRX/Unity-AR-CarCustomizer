using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class rearwheeldrive : MonoBehaviour
{
    public float maxAngle=30;
    public float maxTorque=300;
    public WheelCollider[] WheelColliderArray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle=maxAngle*CrossPlatformInputManager.GetAxis("Horizontal");
        float torque=maxTorque*CrossPlatformInputManager.GetAxis("Vertical");

        WheelColliderArray[0].steerAngle=angle;
        WheelColliderArray[1].steerAngle=angle;

        WheelColliderArray[2].motorTorque=torque;
        WheelColliderArray[3].motorTorque=torque;
        
        foreach(WheelCollider WheelCollider in WheelColliderArray){
            Vector3 p;
            Quaternion r;
            WheelCollider.GetWorldPose(out p,out r);
            Transform wheelModel =WheelCollider.transform.GetChild(0);
            wheelModel.position=p;
            wheelModel.rotation=r;
        }
    }
}
