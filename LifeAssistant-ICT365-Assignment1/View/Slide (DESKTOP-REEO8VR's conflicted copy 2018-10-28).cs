using System;
using System.Drawing;
using System.Windows.Forms;

namespace LifeAssistant_ICT365_Assignment1.View
{
    class Slide
    {
        Panel pane;
        Button btn;
        bool hidden;
        Timer t;
        const int maxWidth = 315;
        Viewer viewer = Viewer.Instance();

        public Slide(Panel p, Button b)
        {
            pane = p;
            btn = b;
            hidden = true;
			pane.Location = new Point(67, 0);
			pane.Size = new Size(0, 652);

            btn.Click += new EventHandler(btnClick);

            t = new Timer();
            t.Interval = 15;
            t.Tick += new EventHandler(timeTick);
        }

        private void timeTick(object sender, EventArgs e)
        {
            if(hidden)
            {
                SlidingPane(+10);
            }
            else
            {
                SlidingPane(-10);
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            if (!viewer.SettingsP.hidden)
            {
                viewer.SettingsP.t.Start();
            }
            else if(!viewer.CalendarP.hidden)
            {
                viewer.CalendarP.t.Start();
            }
            else if(!viewer.PeopleP.hidden)
            {
                viewer.PeopleP.t.Start();
            }
            else if (!viewer.MenuP.hidden)
            {
                viewer.MenuP.t.Start();
            }
            else if (!viewer.TaskP.hidden)
            {
                viewer.TaskP.t.Start();
            }
            else if (!viewer.RouteP.hidden)
            {
                viewer.RouteP.t.Start();
            }

            t.Start();
        }

        private void SlidingPane(int i)
        {
            pane.Width += i;

            if(pane.Width >= maxWidth || pane.Width <= 0)
            {
                t.Stop();
                hidden = !hidden;
            }
                
        }
    }
}
