using System;

using UIKit;

namespace CalculaterLAB3
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void BTNone_TouchUpInside(UIButton sender)
        {
            MainLBL.Text += "1";
        }

        partial void BTNtwo_TouchUpInside(UIButton sender)
        {
            MainLBL.Text += "2";
        }

        partial void BTNthree_TouchUpInside(UIButton sender)
        {
            MainLBL.Text += "3";
        }

        partial void BTNfour_TouchUpInside(UIButton sender)
        {
            MainLBL.Text += "4";
        }

        partial void BTNfive_TouchUpInside(UIButton sender)
        {
            MainLBL.Text += "5";
        }

        partial void BTNsix_TouchUpInside(UIButton sender)
        {
            MainLBL.Text += "6";
        }

        partial void BTNseven_TouchUpInside(UIButton sender)
        {
            MainLBL.Text += "7";
        }

        partial void BTNeight_TouchUpInside(UIButton sender)
        {
            MainLBL.Text += "8";
        }

        partial void BTNnine_TouchUpInside(UIButton sender)
        {
            MainLBL.Text += "9";
        }

        partial void BTNfourthteen_TouchUpInside(UIButton sender)
        {
            MainLBL.Text = String.Empty;
        }

        partial void BTNzero_TouchUpInside(UIButton sender)
        {
            MainLBL.Text += "0";
        }
        string TEXTone = string.Empty;
        string TEXTtwo = string.Empty;
        string result;
        char operation;

        partial void BTNten_TouchUpInside(UIButton sender)
        {
            TEXTone = MainLBL.Text;
            operation = '+';
            MainLBL.Text = string.Empty;
        }

        partial void BTNfifthteen_TouchUpInside(UIButton sender)
        {
            TEXTtwo = MainLBL.Text;

            double numONE;
            double numTWO;
            double.TryParse(TEXTone, out numONE);
            double.TryParse(TEXTtwo, out numTWO);

            switch (operation)
            {
                case '+':
                    result = (numONE + numTWO).ToString();
                    break;

                default:
                    MainLBL.Text = "You did math wrong";
                    break;
            }

            MainLBL.Text = result.ToString();
        }
    }
}