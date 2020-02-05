using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowing : Seek
{
    public float getParam(Vector3 position, float lastParam)
    {
        //Dummy values because I don't know what is suppoosed to go here
        return -1;
    }

    public Vector3 getPosition(float param)
    {
        //Dummy values because I don't know what is suppoosed to go here
        return Vector3.zero;
    }
    PathFollowing path;
    float pathOffset;
    float currentParam;

    float predictTime = .1f;

    public override SteeringOutput getSteering()
    {
        Vector3 futurePos = character.transform.position + (character.linearVelocity * predictTime);

        currentParam = path.getParam(futurePos, character.transform.position.z);

        float targetParam = currentParam + pathOffset;

        target.transform.position = path.getPosition(targetParam);

        return getSteering();
    }
}
