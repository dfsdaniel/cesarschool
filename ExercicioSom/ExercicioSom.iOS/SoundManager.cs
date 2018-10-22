using System;
using AVFoundation;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(ExercicioSom.iOS.SoundManager))]
 
namespace ExercicioSom.iOS
{
    public class SoundManager : IAudioManager
    {
        AVAudioPlayer player;

        public void Play()
        {
            NSUrl url = new NSUrl("Sons/hinosport.mp3");
            NSError error;

            player = new AVAudioPlayer(url, "mp3", out error);
            player.Volume = 1.0f;
            player.NumberOfLoops = -1;

            player.Play();
        }
    }
}
