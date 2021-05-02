using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
	//create an array to store character game objects
	public GameObject[] characters;
	
	
	//set selectedCggaracter to 0
	public int selectedCharacter = 0;
	public int selectedEnemy = 0;

	//sets selected charcter to false, finds next character in array and sets it equal to true
	public void NextCharacter()
	{
		characters[selectedCharacter].SetActive(false);
		selectedCharacter = (selectedCharacter + 1) % characters.Length;
		selectedEnemy = (selectedEnemy + 1) % characters.Length;
		characters[selectedCharacter].SetActive(true);
	}

	//sets selected charcter to false, finds previous character in array and sets it equal to true
	public void PreviousCharacter()
	{
		characters[selectedCharacter].SetActive(false);
		selectedCharacter--;
		selectedEnemy--;
		if (selectedCharacter < 0)
		{
			selectedCharacter += characters.Length;
			selectedEnemy += characters.Length;
		}
		characters[selectedCharacter].SetActive(true);
	}

	//loads opening scence and saves the current character we have selected into the selecteChracter variable 
	public void StartGame()
	{
		PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
		PlayerPrefs.SetInt("selectedEnemy", selectedEnemy);
		SceneManager.LoadScene("openingScene");


	}
}
