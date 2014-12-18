using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScoreManager : MonoBehaviour {

	Dictionary < string, Dictionary < string , int > > playerScore;

	void Init()
	{
		if(playerScore != null)
			return;
		playerScore = new Dictionary< string , Dictionary <string , int > >();
	}

	public int GetScore( string username, string scoreType){
		Init ();

		if (playerScore.ContainsKey (username) == false) {
			//We have no score recordet at all for this username
			return 0;
		}
		if (playerScore [username].ContainsKey (scoreType) == false) {
			return 0;		
		}

		return playerScore [username] [scoreType];
	}

	public void SetScore( string username, string scoreType, int value){
		Init ();

		if (playerScore.ContainsKey (username) == false) {
			playerScore[username] = new Dictionary<string, int>();
		}
		playerScore [username] [scoreType] = value;
	}

	public void ChangeScore( string username, string scoreType, int amount){
		Init ();

		int currScore = GetScore (username, scoreType);
		SetScore (username, scoreType, currScore + amount);
	}

}
