using System;

class ScriptureMemorizer
{
	private Scripture _scripture;
	private List<string> _scriptureTextList;

	public ScriptureMemorizer(Scripture scripture)
	{
		_scripture = scripture;
		_scriptureTextList = new List<string>();
		convertTextToList();
	}

	private void convertTextToList()
	{
		_scriptureTextList = _scripture.toString().Split(' ').ToList();
	}	

	public void removeWordsFromText()
	{
		int numWordsToRemove = new Random().Next(2,4); //will remove 2 or 3
		int wordsRemoved = 0;
		int wordsRemaining = 0;

		do {
			int rndIndex = new Random().Next(0, _scriptureTextList.Count());

			if (_scriptureTextList[rndIndex].Contains('_') == false)
			{
				_scriptureTextList[rndIndex] = new string('_', _scriptureTextList[rndIndex].Length);
				wordsRemoved++;
			}

			// count number of words removed. 
			foreach (string dashedWord in _scriptureTextList)
			{
				if (dashedWord.Contains('_') == false)
				{
					wordsRemaining++;
				}
			}

			if (wordsRemaining < 2)
			{
				break;
			}


		} while (wordsRemoved != numWordsToRemove);
	}

	public string toString()
	{
		return string.Join(' ', _scriptureTextList);
	}

	public bool hasWordsLeft()
	{
		bool retvalue = false;

		foreach (string word in _scriptureTextList)
		{
			if(word.Contains('_') == false) //if a word does not have an underscore
			{
				retvalue = true; //Then I still have words to use.
				break;
			}
		}

		return retvalue;
	}

}