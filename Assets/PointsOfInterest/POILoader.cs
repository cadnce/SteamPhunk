using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using SimpleJSON;


public class POILoader : MonoBehaviour {
	public string BaseURL;

	string curiosity_endpoint = "/arcgis/rest/services/martian_waypoints/MapServer/0/query?f=json&where=1=1&outFields=*";

	List<string> points;

	// Use this for initialization
	void Start () {
		BaseURL = "http://mars2-532959285.us-west-1.elb.amazonaws.com";
		Debug.Log ("Start");
		loadPointsOfInterest ();
		Debug.Log ("Done");
	}
	
	// Update is called once per frame
	void Update () {
	}


	void loadPointsOfInterest()
	{
		Debug.Log ("THis");
		// Download the base json
		WWW www = new WWW (BaseURL + curiosity_endpoint);
		while (!www.isDone) {
		}

		JSONNode root = SimpleJSON.JSON.Parse (www.text);
		JSONArray features = root ["features"].AsArray;

		// Yea, something about parsing the points grabing the title, coords and body text.


		/*
		foreach (JSONArray j in root ["features"].AsArray) {
			Debug.Log (j ["attributes"] ["name"]);
			//points.Add (j [0] ["attributes"] ["name"]);
			Debug.Log ("BLH");
		}
		*/


	}



}
