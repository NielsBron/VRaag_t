using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransformScript : MonoBehaviour
{
    [SerializeField] private Transform lookAt;
    [SerializeField] private Transform transformToFollow;
    [SerializeField] private float followSpeed;

    private Transform _thisTransform;

    private void Start()
    {
        _thisTransform = transform;
    }

    private void Update()
    {
    // Makes UI look at the camera and puts it on the position of gameObject
        _thisTransform.LookAt(lookAt, Vector3.up);
        _thisTransform.Rotate(0f, 180f, 0f);
        var newPosition = _thisTransform.position;
        var followPosition = transformToFollow.position;
        newPosition.x = Mathf.Lerp(newPosition.x, followPosition.x, followSpeed * Time.deltaTime);
        newPosition.y = Mathf.Lerp(newPosition.y, followPosition.y, followSpeed * Time.deltaTime);
        newPosition.z = Mathf.Lerp(newPosition.z, followPosition.z, followSpeed * Time.deltaTime);
        transform.position = newPosition;
    }

    /*private Vector3 LookPoint(Transform target)
    {
        var lookPoint = target.position - _thisTransform.position;
        lookPoint.y = _thisTransform.up.y;
        return lookPoint;
    }*/
}
