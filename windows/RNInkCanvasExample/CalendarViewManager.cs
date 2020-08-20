using Microsoft.ReactNative;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RNInkCanvasExample
{
    class CalendarViewManager : IViewManager
    {
        public string Name => "CalendarCS";

        private CalendarView calendarView;

        public FrameworkElement CreateView()
        {
            calendarView = new CalendarView();

            return calendarView;
        }

    }
}
