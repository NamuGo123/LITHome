/*******************************************************************************************
  (NOTE: demo purposes only!) SIMPL# Pro Module Information
*******************************************************************************************/
/*
Dealer Name: Leading IT Middle East
System Name:
System Number:
Programmer: Namu Go
Comments: This is a Proof-Of-Concept (POC) for converting a SIMPL+ module to SIMPL# Pro.
          It is not intended for production use and may not include all features of the original.
          The code is based on "LITHome v4 Lights Channel v1.usp".
*/


using System;
using Crestron.SimplSharp;

namespace LITHomeLibrary
{
    public class LightEventArgs : EventArgs // used for methods inside event handlers
    {
        public int IntData = 0;
        public string StringData = "";

        public LightEventArgs() { } //must exist for SIMPL+ compliance
        public LightEventArgs(int data) { IntData = data; }
        public LightEventArgs(string data) { StringData = data; }
    }

    public class LightsChannelV1
    {
        
        // public Action Is_On;
        // public Action Is_Off;
        // public Action<ushort> Channel_Level_fb;

        public void TogglePressed()
        {
            CrestronConsole.PrintLine("LightsChannelV1.TogglePressed");
            // TODO:  Add logic here
        }

        public void Channel_Level_Set(ushort value)
        {
            CrestronConsole.PrintLine("LightsChannelV1.Channel_Level_Set {0}", value);
            // TODO:  Add logic here
        }



        // Constructor
        public LightsChannelV1() { }
    }
}