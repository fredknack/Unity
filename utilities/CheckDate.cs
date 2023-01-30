using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDate : MonoBehaviour
{
    void Start() {
        print(CheckTheDate());
    }
    public bool CheckTheDate()
    {
        string dateInput = "2023/01/31";

        System.DateTime parsedDate = System.DateTime.Parse(dateInput); 

        if (System.DateTime.Now > parsedDate){
            return true;
        } else {
            return false;
        }
    }
}
