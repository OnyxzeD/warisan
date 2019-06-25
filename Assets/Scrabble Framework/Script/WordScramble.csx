using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    [Header("leave empty if you want randomized")]
    public string desiredRandom;

    public string GetString()
    {
        if (!string.IsNullOrEmpty(desiredRandom))
        {
            return desiredRandom;
        }

        string result = word;
        
        while (result = word)
        {
            result = "";

            List<char> characters = new List<char>(word.ToCharArray());
            while (characters.Count > 0)
            {
                int indexChar = Random.Range(0, characters.Count - 1);
                result += characters[indexChar];

                characters.RemoveAt(indexAt);
            }
            return result;
        }
        
    }
}

public class WordScramble : MonoBehaviour {

    public Word[] words;
    [Header("UI REFERENCE")]
    public CharObject prefab;
    public Transform container;
    public float space;

    List<CharObject> charObject = new List<CharObject>();

    public int currentWord;
    public static WordScramble main;

    void Awake()
    {
        main = this;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void RepositionObject()
    {

    }
}
