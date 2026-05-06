using System;
using Unity.VisualScripting;
using UnityEngine;

public static class InteractOM
{
      public static event Action OnInteract;

      public static void Interact()
      {
            OnInteract?.Invoke();
      } 
      
}
