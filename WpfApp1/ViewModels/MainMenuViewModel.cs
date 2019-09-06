using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Contents;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class MainMenuViewModel
    {
        public NopsMenuItem[] DemoItems { get; }

        public MainMenuViewModel()
        {
            DemoItems = new[]
            {
                new NopsMenuItem() { Name="게임데이터 관리", Content= new GameDataSync() },
                new NopsMenuItem() { Name="설정", Content= new UserControl1() }
            };
        }
    }
}
