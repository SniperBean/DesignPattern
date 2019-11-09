using System;

/*
    外觀(門面)模式 Facade
    目的: 用一個介面包裝各個子系統，由介面與客戶端做溝通。

    先暫時離開冒險者村一下，筆者親戚家有個豪華的視聽遊樂室。
    包含了液晶電視、電視盒、重低音放大器、DVD播放器、KTV點歌系統、PS3...等等。
    如果想要用PS3看藍光電影，必須依照下列步驟，如果一個步驟錯了就可能沒有影像或聲音。
    1.開啟總電源
    2.開啟液晶電視
    3.打開重低音放大器並等待三秒
    4.打開PS3
    5.放入藍光光碟
    6.選擇播放電影

    每次要看電影都要想一下步驟，很麻煩
    如果由一個遙控器按鈕按下去一鍵完成該有多好。
    外觀(門面)模式就像是一個超級遙控器,把所有看電影要啟動的裝置整合到遙控器裡，方便使用者操作。
    經由Facade的統一包裝管理後，使用者(Client)要使用這些影音設備就變得簡單許多。
*/

namespace Facade
{
    //外觀模式-測試(Client)
    class MainClass
    {
        public static void Main(string[] args)
        {
            VedioRoomFacade superRemote = new VedioRoomFacade();

            Console.WriteLine("========外觀(門面)模式測試========");
            Console.WriteLine("以下測試碼可以看出使用外觀模式使用後會比一個一個步驟操作使用來的方便");

            Console.WriteLine("---看電視---");
            superRemote.readyPlayMovie("AAAAAAdvenger");
            superRemote.playMovie();
            superRemote.showAllStatus();
            Console.WriteLine();

            Console.WriteLine("---關機器---");
            superRemote.turnOffAll();
            superRemote.showAllStatus();
            Console.WriteLine();

            Console.WriteLine("---看電視---");
            superRemote.watchTv();
            superRemote.showTv();
            superRemote.switchChannel(20);
            superRemote.showTv();
            superRemote.turnOffAll();
            Console.WriteLine();


            Console.WriteLine("---唱KTV---");
            superRemote.readyKTV();
            superRemote.selectSong("El Latido de mi Corazón");
            superRemote.playSong();
            superRemote.showAllStatus();
        }
    }
}
