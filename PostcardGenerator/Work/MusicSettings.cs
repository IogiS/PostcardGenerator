using System;
using System.Windows.Media;

namespace PostcardGenerator.Work
{
    class MusicSettings
    {

        public static MediaPlayer mediaPlayer = new MediaPlayer();
        public static void AddNewSong(string path) => mediaPlayer.Open(new Uri(path));

        public static void Play() => mediaPlayer.Play();

        public static void Stop() => mediaPlayer.Stop();

        public static void Pause() => mediaPlayer.Pause();

        public static void ChangeVolume(double volume) => mediaPlayer.Volume = volume;



    }
}
