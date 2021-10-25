using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Cam : MonoBehaviour
{
    [SerializeField] Transform trackingTarget;
    public PostProcessVolume _volume;
    private ColorGrading _color;


    
     public float _xOffset;
    [SerializeField]
    float _yOffset;

    [SerializeField]
    protected float followSpeed;

    [SerializeField]
    protected bool isXLocked = false;

    [SerializeField]
    protected bool isYLocked = false;

    private void Start()
    {
        _volume.profile.TryGetSettings(out _color);
    }

    private void Update()
    {
        float xTarget = trackingTarget.position.x + _xOffset;
        float yTarget = trackingTarget.position.y + _yOffset;

        float xNew = transform.position.x;
        if (!isXLocked)
        {
            xNew = Mathf.Lerp(transform.position.x, xTarget, Time.deltaTime * followSpeed);
        }

        float yNew = transform.position.y;
        if (!isYLocked)
        {
            yNew = Mathf.Lerp(transform.position.y, yTarget, Time.deltaTime * followSpeed);
        }

        transform.position = new Vector3(xNew, yNew, transform.position.z);
    }
    public void ChangeOffset()
    {
        _xOffset = -6.33f;
    }

    public void ChangeColor()
    {
        _color.active = true;
       
    }
}
