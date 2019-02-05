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
        Viewer view = Viewer.Instance();

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
            if(!view.SettingsP.hidden)
            {
                t.Start();
            }
            else if(!view.MenuP.hidden)
            {
                t.Start();
            }
            else if(!view.TaskP.hidden)
            {
                t.Start();
            }
            else if(!view.PeopleP.hidden)
            {
                t.Start();
            }
            else if(!view.CalendarP.hidden)
            {
                t.Start();
            }
            else if(!view.RouteP.hidden)
            {
                t.Start();
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
