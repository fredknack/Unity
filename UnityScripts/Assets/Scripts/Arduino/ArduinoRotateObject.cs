using UnityEngine;
using System.Collections;
//using System.IO.Ports;

public class ArduinoRotateObject : MonoBehaviour {
    float speed = 30f;

    //SerialPort sp = new SerialPort("COM3", 9600);
    // Use this for initialization
    void Start () {
        //sp.Open();
        //sp.ReadTimeout = 1;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
		/*
        if (sp.IsOpen)
        {
            try
            {
                //ChangeDirection(sp.ReadByte());
                //print(sp.ReadByte());
            }
            catch (System.Exception)
            {
                //throw;
            }
        }
        */
    }

    void ChangeDirection(int Direction)
    {
        if (Direction == 1)
        {
            speed = 30f;
        }

        if (Direction == 2)
        {
            speed = -30f;
        }
    }
}
