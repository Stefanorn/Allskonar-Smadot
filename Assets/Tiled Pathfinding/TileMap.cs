using UnityEngine;
using System.Collections;

public class TileMap : MonoBehaviour {

	public TileType[] tileType;

	int[,] tiles;
	
	int mapSizeX = 10;
	int mapSizeY = 10;


	// Use this for initialization
	void Start () {

		//Allocate our Map tiles
		tiles = new int[mapSizeX, mapSizeX];

		// Initalize our map Tiles
		for (int x=0; x < mapSizeX; x++) {
			for( int y=0; y < mapSizeY; y++ ){
				tiles[x,y] = 0;
			}
		}

		// Ushaped Mountain

		tiles [4, 4] = 2;
		tiles [5, 4] = 2;
		tiles [6, 4] = 2;
		tiles [7, 4] = 2;
		tiles [8, 4] = 2;

		tiles [8, 5] = 2;
		tiles [8, 6] = 2;

		tiles [4, 5] = 2;
		tiles [4, 6] = 2;

		GenareteMapVisual ();
	}
	void GenareteMapVisual(){
		for (int x=0; x < mapSizeX; x++) {
			for( int y=0; y < mapSizeY; y++ ){
				Instantiate( tileType[ tiles[x, y] ].tileVisulPrefab, new Vector3(x,y,0), Quaternion.identity);
			}
		}
	}
}