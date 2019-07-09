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
        
        while (result == word)
        {
            result = "";

            List<char> characters = new List<char>(word.ToCharArray());
            while (characters.Count > 0)
            {
                int indexChar = Random.Range(0, characters.Count - 1);
                result += characters[indexChar];

                characters.RemoveAt(indexChar);
            }
        }
        return result;
    }
}

public class WordScramble : MonoBehaviour {

    public Word[] words;
    /*public string[] words = {"BUKIT","BAKTI","KERJA","JALAN","MAKAN",
                             "MINUM","AROMA","KUMAN","SURAT","LEMAS",
                             "CUKUR"};*/
    [Header("UI REFERENCE")]
    public CharObject prefab;
    public Transform container;
    public float space;
    public float lerpSpeed = 5;
    public float checkSpeed = 1;
    public HeroAnimController hac;
    public BossAnimController bac;
    public CooldownController cooldownControl;

    List<CharObject> charObjects = new List<CharObject>();
    CharObject firstSelected;

    //private bool BossAutoAttack = false;
    public int currentWord;
    public static WordScramble main;

    void Awake()
    {
        main = this;
    }
	// Use this for initialization
	void Start () {
        ShowScramble(currentWord);
	}
	
	// Update is called once per frame
	void Update () {
        RepositionObject();
	}

    void RepositionObject()
    {
        if (charObjects.Count == 0)
        {
            return;
        }
        float center = (charObjects.Count - 1) / 2;
        for(int i = 0; i < charObjects.Count; i++)
        {
            charObjects[i].rectTransform.anchoredPosition
                = Vector2.Lerp(charObjects[i].rectTransform.anchoredPosition, 
                    new Vector2((i - center) * space, 0), lerpSpeed * Time.deltaTime);
            charObjects[i].index = i;
        }
    }

    /// <summary>
    /// Show random word to the screen
    /// </summary>
    public void ShowScramble()
    {
        ShowScramble(Random.Range(0, words.Length - 1));
    }

    /// <summary>
    /// Show word from collection with desired index
    /// </summary>
    /// <param name="index"></param>
    public void ShowScramble(int index)
    {
        charObjects.Clear();
        foreach(Transform child in container)
        {
            Destroy(child.gameObject);
        }

        if(index > words.Length - 1)
        {
            Debug.LogError("Index Out of Range, please enter range between 0-" + (words.Length - 1).ToString());
            return;
        }

        char[] chars = words[index].GetString().ToCharArray();
        foreach(char c in chars)
        {
            CharObject clone = Instantiate(prefab.gameObject).GetComponent<CharObject>();
            clone.transform.SetParent(container);

            charObjects.Add(clone.Init(c));
        }

        currentWord = index;
    }

    public void Swap(int indexA, int indexB)
    {
        CharObject tmpA = charObjects[indexA];
        charObjects[indexA] = charObjects[indexB];
        charObjects[indexB] = tmpA;

        charObjects[indexA].transform.SetAsLastSibling();
        charObjects[indexB].transform.SetAsLastSibling();

        CheckWord();
    }

    public void Select(CharObject charObject)
    {
        if (firstSelected)
        {
            Swap(firstSelected.index, charObject.index);

            //Unselect
            
            firstSelected.Select();
            charObject.Select();
        }
        else
        {
            firstSelected = charObject;
        }
    }

    public void Unselect()
    {
        firstSelected = null;
    }

    public void CheckWord()
    {
        StartCoroutine(CoCheckWord());
        
    }

    IEnumerator CoCheckWord()
    {
        string word = "";
        foreach (CharObject charObject in charObjects)
        {
            word += charObject.character;
        }

        if (word == words[currentWord].word)
        {
            hac.HeroAttack();
            cooldownControl.setAutoAttack(true);
            yield return new WaitForSeconds(checkSpeed);
            currentWord++;
            ShowScramble(currentWord);
        }
    }
}
