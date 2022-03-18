using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class SocketWithObj : XRSocketInteractor
{
    public override bool CanHover(IXRHoverInteractable interactable)
    {
        return base.CanHover(interactable);
    }

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable);
    }
 
}
