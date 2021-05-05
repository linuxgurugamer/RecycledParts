using System;
using System.Collections.Generic;
using UnityEngine;

namespace BDMk22Plugin
{
	public class HUDNumberField
	{
		public enum HUDNumberAlign{Left, Right};

		public GameObject[] digitObjects;

		HUDNumberAlign alignment;

		int[] digits;
		UVTransformer[] UVTs;
		Transform transform;

		float charWidth;
		float charPixelWidth;
		int digCount;

		int currValue = -1;

		int maxValue = 0;

		public int digitCount
		{
			get	
			{
				return digCount;	
			}
		}

		public HUDNumberField(Transform transform, int digitCount, float scale, GameObject digitReference, float charWidth, float charPixelWidth, HUDNumberAlign alignment)
		{
			this.transform = transform;
			this.charWidth = charWidth;
			this.charPixelWidth = charPixelWidth;
			this.alignment = alignment;
			digCount = digitCount;

			digitObjects = new GameObject[digitCount];
			UVTs = new UVTransformer[digitCount];
			digits = new int[digitCount];
			for(int i = 0; i < digitCount; i++)
			{
				GameObject digitObject = (GameObject)GameObject.Instantiate(digitReference);
				digitObjects[i] = digitObject;
				digitObject.transform.parent = transform;
				digitObject.transform.localScale = Vector3.one;
				digitObject.transform.localPosition = Vector3.zero;
				digitObject.transform.localRotation = Quaternion.identity;
				digitObject.SetActive(true);
				if(alignment == HUDNumberAlign.Right)
				{
					digitObject.transform.localPosition -= (charWidth * digitCount) * Vector3.right;
				}
				digitObject.transform.localPosition += (charWidth * i) * Vector3.right;

				UVTs[i] = new UVTransformer(digitObject);

				transform.localScale = scale*Vector3.one;

				digits[i] = -1;
			}

			char[] maxValChars = new char[digitCount];
			for(int i = 0; i < digitCount; i++)
			{
				maxValChars[i] = '9';	
			}
			string maxValString = new string(maxValChars);
			maxValue = int.Parse(maxValString);
		}

		public void Destroy()
		{
			if(digitObjects != null)
			{
				for(int i = 0; i < digitObjects.Length; i++)
				{
					if(digitObjects[i])
					{
						GameObject.Destroy(digitObjects[i]);
					}
				}
			}
		}

		public void SetValue(int val)
		{
			val = Mathf.Clamp(val, -1, maxValue);

			if(currValue!=val)
			{
				//Debug.Log ("Setting value: "+val);
				currValue = val;

				if(val < 0)
				{
					for(int i = 0; i < digitCount; i++)	
					{
						SetDigit(-1, i);	
					}
				}

				string intString = val.ToString();

				int[] digits;
				if(val == 0)
				{
					digits = new int[]{ 0 };
				}
				else
				{
					List<int> listOfInts = new List<int>();
					int num = val;
					while(num > 0)
					{
						listOfInts.Add(num % 10);
						num = num / 10;
					}
					listOfInts.Reverse();
					digits = listOfInts.ToArray();
				}
					
				int valDigitCount = digits.Length;//intString.Length;
				int extraChars = digitCount-valDigitCount;

				if(alignment == HUDNumberAlign.Right)
				{
					//set extra spaces to blank
					for(int i = 0; i < extraChars; i++)
					{
						SetDigit(-1, i);	
					}

					for(int i = 0; i < valDigitCount; i++)
					{
						int digit = digits[i];//int.Parse(intString.Substring(i, 1));	
						int index = extraChars + i;
						SetDigit(digit, index);
					}
				}
				else
				{
					for(int i = 0; i < valDigitCount; i++)
					{
						int digit = digits[i];//int.Parse(intString.Substring(i, 1));	
						SetDigit(digit, i);	
					}

					for(int i = 0; i < extraChars; i++)
					{
						int index = valDigitCount + i;	
						SetDigit(-1, index);
					}
				}
			}
		}

		void SetDigit(int digit, int index)
		{
			if(digit != digits[index])
			{
				UVTs[index].UpdateUVTransformation(new Vector2(charPixelWidth * (digit+1), 0), 0, Vector2.zero, Vector2.zero);	
				digits[index] = digit;
			}
		}
	}
}

