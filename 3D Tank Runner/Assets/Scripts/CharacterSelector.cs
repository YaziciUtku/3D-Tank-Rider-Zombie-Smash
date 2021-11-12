 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerSpawnPosition = new Vector3(0, 0, -2);
    public Character[] characters;

    public void StartGame(int characterCoice)
    {
        GameObject spawnedPlayer = Instantiate(player, playerSpawnPosition, Quaternion.identity)as GameObject;
        Character selectedCharacter = characters[characterCoice]; 
    }
}
