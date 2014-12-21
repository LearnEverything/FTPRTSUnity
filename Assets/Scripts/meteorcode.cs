using UnityEngine;
using System.Collections;

public class meteorcode : MonoBehaviour {
	public string meteorURL = "ws://192.168.177.132:3000/websocket";
	// Use this for initialization
	void Start () {
		//Meteor.Connection.Logging = true;
		Security.PrefetchSocketPolicy("192.168.177.132", 5000);
		StartCoroutine(MeteorExample());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator MeteorExample() {

		yield return Meteor.Connection.Connect (meteorURL);
		joinMap();
		var collection = Meteor.Collection<MeteorMap>.Create ("maps");
		var subscription = Meteor.Subscription.Subscribe("allMaps");
		collection.DidAddRecord += (string id, MeteorMap doc) => {
			Debug.Log (id + " " + doc._id);
			Debug.Log (doc.assetName);
			//Debug.Log (.stringField("label"));
			//Debug.Log(string.Format("Document added:\n{0}", document.ToString()));
		};
		yield return (Coroutine)subscription;
		//var subscription = Meteor.Subscription.Subscribe ("subscriptionEndpointName", /*arguments*/ 1, 3, 4);
		// Create a method call that returns a string
		//var methodCall = Meteor.Method<string>.Call ("testString" /*arguments*/);
		
		// Execute the method. This will yield until all the database sideffects have synced.
		//yield return (Coroutine)methodCall;
		//Debug.Log ("called method?");
		// Get the value returned by the method.
		//Debug.Log (string.Format ("Method response:\n{0}", methodCall.Response));
	}
	void joinMap() {

	}
}

public class MeteorMap : Meteor.MongoDocument {
	public string assetName;
	public string title;
}
