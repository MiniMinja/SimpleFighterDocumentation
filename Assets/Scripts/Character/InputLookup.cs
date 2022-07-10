using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputLookup : MonoBehaviour
{
    public static readonly string LEFT = "left";
    public static readonly string RIGHT = "right";
    public static readonly string UP = "up";
    public static readonly string DOWN = "down";

    Dictionary<string, bool> inputKeys;

    void Start(){
        inputKeys = new Dictionary<string, bool>();

        string[] inputStr = {
            "left", "right", "up", "down",          // Movement related 
            "jump"
        };

        foreach(string s in inputStr){
            inputKeys.Add(s, false);
        }
    }

    void Update(){
        float horAxis = Input.GetAxisRaw("Horizontal");
        if(horAxis == -1){
            inputKeys[LEFT] = true;
            inputKeys[RIGHT] = false;
        }
        else if(horAxis == 1){
            inputKeys[LEFT] = false;
            inputKeys[RIGHT] = true;
        }
        else{
            inputKeys[LEFT] = false;
            inputKeys[RIGHT] = false;
        }

        float vertAxis = Input.GetAxisRaw("Vertical");
        if(vertAxis == -1){
            inputKeys[DOWN] = true;
            inputKeys[UP] = false;
        }
        else if(vertAxis == 1){
            inputKeys[DOWN] = false;
            inputKeys[UP] = true;
        }
        else{
            inputKeys[DOWN] = false;
            inputKeys[UP] = false;
        }
    }

    public bool Lookup(string key){
        return inputKeys[key];
    }
}
