using _13;

AudioPlayer audio = new AudioPlayer();
VideoPlayer video = new VideoPlayer();

audio.Play();
audio.Volume = 50;
audio.Pause();

video.Play();
video.Pause();

foreach (string song in audio)
{
   Console.WriteLine("Playlist song: " + song);
}