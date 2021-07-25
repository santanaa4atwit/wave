using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave2.Classes
{
    static class AutoPlayl
    {
        public static bool AutoPlay = false;
        public static bool AllowRepitition = false;
        public static bool AllowShuffle = false;
        public static string CurrentTrack { get; set; }

        public static void AutoPlayStarts(AxWMPLib.AxWindowsMediaPlayer player)
        {
            if (AutoPlay)
            {
                if (AllowShuffle == false)
                {
                    Controlcen.OpenMedia(List.GetFirstTrack, player);
                    CurrentTrack = List.GetFirstTrack;
                }

                else
                {
                    CurrentTrack = List.GetRandomTrack;
                    Controlcen.OpenMedia(CurrentTrack, player);
                }
            }
        }

        public static void PlayNextTrack(AxWMPLib.AxWindowsMediaPlayer player)
        {
            if (AutoPlay)
            {
                CurrentTrack = List.SelectTrack('N', CurrentTrack, AllowRepitition, AllowShuffle);
                Controlcen.OpenMedia(CurrentTrack, player);
            }
        }

        public static void PlayPreviousTrack(AxWMPLib.AxWindowsMediaPlayer player)
        {
            if (AutoPlay)
            {
                CurrentTrack = List.SelectTrack('P', CurrentTrack, AllowRepitition, AllowShuffle);
                Controlcen.OpenMedia(CurrentTrack, player);
            }
        }

        //maybe not needed
        public static void ReInstantiate()
        {
            AutoPlay = true;
            AllowRepitition = false;
            AllowShuffle = false;
        }
    }
}
