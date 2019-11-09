using System;
namespace Facade
{
    //管理影音設備的外觀類別(Facade)

    public class VedioRoomFacade
    {
        // 房間內共有這些影音設備
        Television tv = new Television();
        Stereo stereo = new Stereo();
        PlayStation3 ps = new PlayStation3();
        KTVsystem ktv = new KTVsystem();

        //準備用PS3看電影
        public void readyPlayMovie(String cd)
        {
            stereo.powerOn();
            tv.powerOn();
            tv.setSound(50);
            tv.switchSource("ps");
            ps.powerOn();
            ps.putCd(cd);
        }

        //用PS3放電影
        public void playMovie()
        {
            if(ps.isPowerOn())
            {
                ps.play();
            }
        }

        //看目前觀看的電視頻道
        public void showTv()
        {
            tv.showTv();
        }

        //關閉全部設備
        public void turnOffAll()
        {
            tv.powerOff();
            stereo.powerOff();
            ktv.powerOff();
            ps.powerOff();
        }

        //看電視
        public void watchTv()
        {
            tv.powerOn();
            tv.switchSource("tvBox");
        }

        //選電視頻道
        public void switchChannel(int channel)
        {
            tv.switchChannel(channel);
        }

        //準備KTV
        public void readyKTV()
        {
            stereo.powerOn();
            ktv.powerOn();
            tv.powerOn();
            tv.setSound(50);
            tv.switchSource("ktv");
        }

        //ktv點歌
        public void selectSong(String song)
        {
            if(ktv.isPowerOn())
            {
                ktv.selectSong(song);
            }
        }

        //ktv播放歌曲
        public void playSong()
        {
            if (ktv.isPowerOn())
            {
                ktv.playSong();
            }
        }

        //設定音量
        public void setSound(int soundLevel)
        {
            if(tv.isPowerOn())
            {
                tv.setSound(soundLevel);
            }
            if (stereo.isPowerOn())
            {
                stereo.setSound(soundLevel);
            }
        }

        //顯示所有機器的狀態
        public void showAllStatus()
        {
            tv.showStatus();
            stereo.showStatus();
            ps.showStatus();
            ktv.showStatus();
        }
    }
}
