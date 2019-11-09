using System;
namespace Facade
{
    public abstract class Electronics
    {
        private Boolean power = false; //電源

        public void powerOff()
        {
            this.power = false;
        }

        public void powerOn()
        {
            this.power = true;
        }

        public Boolean isPowerOn()
        {
            return power;
        }

        protected void showStatus()
        {
            if(power)
            {
                Console.WriteLine(this.GetType().Name + " 運作中");
            }
            else
            {
                Console.WriteLine(this.GetType().Name + " 電源未開啟");
            }
        }
    }

    //KTV點歌機
    public class KTVsystem : Electronics
    {
        private String song;

        public void selectSong(String song)
        {
            this.song = song;
        }

        public void playSong()
        {
            Console.WriteLine(this.GetType().Name + " 播放: " + song);
        }

        public new void showStatus()
        {
            base.showStatus();
        }
    }

    //PlayStation 3
    public class PlayStation3 : Electronics
    {
        private String cd;

        public void putCd(String cd)
        {
            this.cd = cd;
        }

        public String getCd()
        {
            return cd;
        }

        public void play()
        {
            Console.WriteLine(this.GetType().Name + " 播放: " + cd);
        }

        public new void showStatus()
        {
            base.showStatus();
             if(isPowerOn())
            {
                Console.WriteLine(this.GetType().Name + " 目前放入CD:" + cd);
            }
        }
    }

    //環繞音響
    public class Stereo : Electronics
    {
        private int sound = 50;

        public void setSound(int sound)
        {
            this.sound = sound;
        }

        public int getSound()
        {
            return sound;
        }

        public new void showStatus()
        {
            base.showStatus();
            if(isPowerOn())
            {
                Console.WriteLine(this.GetType().Name + " 音量為: " + sound);
            }
        }
    }

    //液晶電視
    public class Television : Electronics
    {
        private int sound = 50;
        private String source = "tvBox";
        private int channel = 9;

        public void switchSource(String source)
        {
            this.source = source;
        }

        public void setSound(int sound)
        {
            this.sound = sound;
        }

        public void switchChannel(int channel)
        {
            this.channel = channel;
        }


        public void showTv()
        {
            Console.WriteLine("目前觀看的頻道是: " + channel);
        }

        public new void showStatus()
        {
            base.showStatus();
            if(isPowerOn())
            {
                Console.Write(this.GetType().Name + " 音量為: " + sound);
                if(source.Equals("tvBox"))
                {
                    Console.WriteLine(", 頻道: " + channel);
                }

                if (source.Equals("ktv"))
                {
                    Console.WriteLine(", KTV播放中");
                }

                if (source.Equals("ps"))
                {
                    Console.WriteLine(", PS3畫面顯示中");
                }
            }
        }

        public int getSound()
        {
            return sound;
        }

        public String getSource()
        {
            return source;
        }

        public int getChannel()
        {
            return channel;
        }
    }
}
