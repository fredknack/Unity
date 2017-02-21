using UnityEngine;
using System.Collections;

//Examples of Arrays, Lists, And Dictionaries

//Import for Lists
using System.Collections.Generic;

public class dataStructures : MonoBehaviour {
    //Example of how to create an array
    string[] myArray = new string[]{"One", "Two", "Three", "Four", "Five" };

    //Example of a list
    List<string> myList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

    Dictionary<string,string> myDictionary = new Dictionary<string, string>();


	void Start () {
        //Another way to set array values
        //myArray[0] = "One";
        //myArray[1] = "Two";
        //myArray[2] = "Three";
        //myArray[3] = "Four";
        //myArray[4] = "Five";

        //Add item to list
        myList.Add("fish");
        myList.Add("bear");
        myList.Add("toad");

        //Remove item from list
        myList.Remove("toad");

        //Convert list to array
        print("List to Array Length " + myList.ToArray ().Length);

        //Add item to Dictionary
        myDictionary.Add("itemOne", "cat");

        //Output Array
        print(myArray[3]);
        print("Array Length "+myArray.Length);

        //Output List
        print("List Length " + myList.Count);
        print("Last item in list " + myList[myList.Count-1]);

        //Output Dictionary
        print("Dictionary Item One " + myDictionary["itemOne"]);
        print("Dictionary Item Two Filled " + myDictionary.ContainsKey("itemTwo"));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
