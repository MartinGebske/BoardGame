using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraToAction : MonoBehaviour {

    public float speed = 5;
    public iTween.EaseType easeType = iTween.EaseType.easeOutBack;
    Transform moveToTarget;



	void Start () {
        moveToTarget = gameObject.transform.GetChild(0);

        Transform player = GameObject.FindGameObjectWithTag("Player").transform;


        MoveDramatically(player);
	}


    public void MoveDramatically(Transform zoomTarget)
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "looktarget", zoomTarget,
            "y",zoomTarget.position.y + 3,
            "z",zoomTarget.position.z - 5,
            "speed", speed,
            "easetype", easeType
      ));
    }
}
