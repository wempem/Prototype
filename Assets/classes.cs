using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class classes : MonoBehaviour {

	public List<Sprite> spritesList;
	public Image image;
	public Button button;
	private bool torf = false;
	private int major;
	private bool undergrad = true;
	private Sprite tempSprite;
	public void ChangeClass(int num)
	{
		if (undergrad)
		{
			if (num == 1)
			{

				major = 1;
				turnButtonOn();
				image.sprite = spritesList[0];
			}
			else if (num == 2)
			{
				major = 2;
				turnButtonOff();
				image.sprite = spritesList[3];
			}
			else
			{
				turnButtonOff();
				image.sprite = spritesList[7];
			}
		}
		else
		{
			turnButtonOff();
			if (num == 1)
			{

				major = 1;
				image.sprite = spritesList[6];
			}
			else if (num == 2)
			{
				major = 2;
				image.sprite = spritesList[8];
			}
			else
			{

				image.sprite = spritesList[7];
			}
		}
	}
	public void ChangeCatalog(int num)
	{
		if (!undergrad)
		{
			return;
		}
		
		if (num == 0)
		{
			if(major == 1)
				image.sprite = spritesList[0];
			else
			{
				image.sprite = spritesList[3];
			}
		}
		else if (num == 1)
		{
			if (major == 1)
				image.sprite = spritesList[2];
		}
	}
	public void CourseLevels(int num)
	{
		if (undergrad)
		{
			if (major == 1)
			{

				if (num == 0)
				{
					turnButtonOn();
					image.sprite = spritesList[0];
					return;
				}

				else if (num == 3)
				{
					turnButtonOff();
					image.sprite = spritesList[4];
					return;
				}
				else if (num == 4)
				{
					turnButtonOff();
					image.sprite = spritesList[5];
					return;
				}
				else
				{
					turnButtonOff();
					image.sprite = spritesList[7];
					return;
				}
			}
			else if (major == 2)
			{
				if (num == 0)
				{
					image.sprite = spritesList[3];
					return;
				}
				else
				{
					image.sprite = spritesList[7];
					return;
				}
			}
		}
		else
		{
			if(major == 1)
			{
				if (num == 0)
				{
					image.sprite = spritesList[6];
				}
				else
					image.sprite = spritesList[7];
					return;
			}
			else if(major == 2)
			{
				if(num == 0)
				{
					image.sprite = spritesList[6];
				}
				else
					image.sprite = spritesList[7];
					return;
			}
		}
	}
	public void OnbuttonClick()
	{
		if (torf == false)
		{
			image.sprite = spritesList[1];
			torf = true;
			return;
		}
		else
		{
			image.sprite = spritesList[0];
			torf = false;
			return;
		}
	}
	public void GraduateCatalog(int num)
	{
		if(major == 1)
		{
			if(num == 0)
			{
				turnButtonOn();
				image.sprite = spritesList[1];
				return;
			}
			else
			{
				undergrad = false;
				image.sprite = spritesList[6];
			}
		}
		else if(major == 2)
		{
			if (num == 0)
			{
				image.sprite = spritesList[3];
				return;
			}
			else
			{
				undergrad = false;
				image.sprite = spritesList[8];
			}
		}
		else
		{
			if (num == 0)
			{
				undergrad = true;
				return;
			}
			else
			{
				undergrad = false;
				return;
			}
		}
	}
	private void turnButtonOff()
	{
		button.interactable = false;
	}
	private void turnButtonOn()
	{
		button.interactable = true;
	}
	public void ChangeImage()
	{
		image.sprite = spritesList[1];
		turnButtonOn();
	}
}
