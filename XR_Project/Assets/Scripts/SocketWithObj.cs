using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class SocketWithObj : XRSocketInteractor
{
    public ObjectID objid;
    public EnumDefinition.TYPE type;
    public int numbers;
    void Start()
    {
        GetID();
    }

    public override bool CanHover(IXRHoverInteractable interactable)
    {
        return base.CanHover(interactable) && IsMatchHover(interactable);
    }

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable) && IsMatchSelect(interactable);
    }

    void GetID()
    {
        this.transform.TryGetComponent<ObjectID>(out ObjectID id);
    }

    public bool IsMatchHover(IXRHoverInteractable interactable)
    {
        if (interactable.transform.TryGetComponent<ObjectID>(out ObjectID id))
        {
            bool isMatch = id.aaa == type;

            if (isMatch)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }

    public bool IsMatchSelect(IXRSelectInteractable interactable)
    {
        if (interactable.transform.TryGetComponent<ObjectID>(out ObjectID id))
        {
            bool isMatch = id.aaa == type;
            
            if (isMatch) {

                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }
 
}
