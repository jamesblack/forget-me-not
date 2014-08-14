using UnityEngine;
using System.Collections;

public class Survivor : Entity
{

    public string FirstName = "John";
    public string LastName = "Doe";

    public string FullName { get { return FirstName + " " +  LastName; } }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
