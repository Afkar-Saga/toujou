using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        PlayerInput.Instantiate(prefab: playerPrefab, playerIndex: 0, controlScheme: "WASD", pairWithDevice: Keyboard.current);    
        PlayerInput.Instantiate(prefab: playerPrefab, playerIndex: 1, controlScheme: "Arrows", pairWithDevice: Keyboard.current);    
    }


}
