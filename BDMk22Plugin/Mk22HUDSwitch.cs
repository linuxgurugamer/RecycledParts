using System;
using UnityEngine;

namespace BDMk22Plugin 
{
	public class Mk22HUDSwitch : InternalModule
	{
		Mk22HUD hud;
		public bool buttonHudState = false;

		public void ButtonHUDToggle(bool state)
		{
			if(Mk22HUD.mk22HUDs == null)
			{
				return;
			}

			if(!hud)
			{
				foreach(var h in Mk22HUD.mk22HUDs)
				{
					if(h && h.part == part)
					{
						hud = h;
					}
				}

				if(!hud)
				{
					return;
				}
			}


			this.buttonHudState = state;
			hud.SetHUD(state);

			Debug.Log("setting state: " + state);
		}

		public bool ButtonHUDToggleState()
		{
			Debug.Log("attempting to get hud state");

			if(Mk22HUD.mk22HUDs == null)
			{
				Debug.Log("hud list is null");
				return false;

			}

			if(!hud)
			{
				foreach(var h in Mk22HUD.mk22HUDs)
				{
					if(h && h.part == part)
					{
						hud = h;
					}
				}

				if(!hud)
				{
					Debug.Log("failed to get hud component");
					return false;
				}
			}



			Debug.Log("getting state: " + hud.hasInitialized);

			return hud.hasInitialized;
		}
	}
}

