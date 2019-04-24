using System;
using System.IO;
using System.Reflection;

using Tizen.NUI.Binding;
using Tizen.NUI.Xaml;
using Tizen.NUI;
//using System.ComponentModel;

namespace Tizen.NUI.Examples
{
    
    // class MyAppViewModel : INotifyPropertyChanged
    // {

    //     public event PropertyChangedEventHandler PropertyChanged;
    //     private Command _firstClick;
    //     private int count = 0;
        
    //     private string[] colors = new string[] {"Black", "Blue", "Gray", "Green", "Purple", "Pink", "Red" };
    //     public string TextColor = "Red";
    //     public Command ChangeColor {
    //         get {
    //             return _firstClick ?? (_firstClick = new Command (() => {
    //                 Console.WriteLine ("First button clicked");
    //                 count += 1;
    //                 TextColor = colors[count % 7];
    //             }));
    //         }
    //     }
    
    //     public MyAppViewModel()
    //     {
    //     }

    // }


    public class TestSlider : NUIApplication
    {
        protected override void OnCreate() 
        {
            base.OnCreate();
            Window window = Window.Instance;
            window.BackgroundColor = Color.White;

            SliderTestPage myPage = new SliderTestPage(window);

            // MyPage myPage = new MyPage(win);
            Extensions.LoadFromXaml(myPage, typeof(SliderTestPage));
            
            Console.WriteLine("==================  Set BindingContext in Application !!!! ==================");

        }

        public static void _Main(string[] args)
        {
            TestSlider p = new TestSlider();
            p.Run(args);
        }
    }
}
