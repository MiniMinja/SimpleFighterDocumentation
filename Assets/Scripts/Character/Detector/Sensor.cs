using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    protected char detectingKey;

    bool toCheck;

    void Start(){
        toCheck = false;
    }

    void OnTriggerEnter2D (Collider2D collision){
        if(collision.tag.EndsWith(detectingKey)){
            toCheck = true;
        }
    }

    void OnTriggerExit2D (Collider2D collision){
        if(collision.tag.EndsWith(detectingKey)){
            toCheck = false;
        }
    }

    public bool Detected(){
        return toCheck;
    }
}
