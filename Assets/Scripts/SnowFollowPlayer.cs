using SpatialSys.UnitySDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFollowPlayer : MonoBehaviour
{
    private Vector3 targetPosition;

    void Update()
    {
        Vector3 playerPosition = SpatialBridge.actorService.localActor.avatar.position;

        targetPosition = new Vector3(playerPosition.x, transform.position.y, playerPosition.z);

        transform.position = targetPosition;
    }
}
