using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using SharpBroadlink;
using SharpBroadlink.Devices;
using System.Linq;

namespace BroadlinkManager
{
    public partial class Main : MetroForm
    {

        IDevice[] devs;
        public Main()
        {
            ToolTipAdv tooltip = null;
            TrackBarEx trackBar = new TrackBarEx();
            InitializeComponent();
            tooltip = new ToolTipAdv(this);
            tooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            foreach (CaptionImage image in this.CaptionImages)
            {
                if (image.Name == "CaptionImage6")
                {
                    image.Location = new Point(this.Width - 34, 4);
                }
                else if (image.Name == "CaptionImage7")
                {
                    image.Location = new Point(this.Width - 63, 4);
                }
                else if (image.Name == "CaptionImage8")
                {
                    image.Location = new Point(this.Width - 87, 4);
                }
                if (image.Name == "CaptionImage3")
                {
                    image.Location = new Point(this.Width - 3 * image.Size.Width - 30, 40);
                }
                else if (image.Name == "CaptionImage4")
                {
                    image.Location = new Point(this.Width - 2 * image.Size.Width - 20, 40);
                }
                else if (image.Name == "CaptionImage5")
                {
                    image.Location = new Point(this.Width - image.Size.Width - 10, 40);
                }
                image.ImageMouseEnter += new CaptionImage.MouseEnter(image_ImageMouseEnter);
                image.ImageMouseLeave += new CaptionImage.MouseLeave(image_ImageMouseLeave);
                image.ImageMouseMove += new CaptionImage.MouseMove(image_ImageMouseMove);
                image.ImageMouseUp += new CaptionImage.MouseUp(image_ImageMouseUp);
                this.Resize += new EventHandler(Main_Resize);
            }
            this.HideControlboxHighlights();
        }

        private void Main_Resize(object sender, EventArgs e)
        {

        }

        private void image_ImageMouseUp(object sender, ImageMouseUpEventArgs e)
        {
            CaptionImage ci = sender as CaptionImage;
            switch (ci.Name)
            {
                case "close":
                    Application.Exit();
                    break;
                case "min":
                    this.WindowState = FormWindowState.Minimized;
                    break;
                case "max":
                    if (this.WindowState == FormWindowState.Normal)
                        this.WindowState = FormWindowState.Maximized;
                    else
                        this.WindowState = FormWindowState.Normal;
                    break;
                default:
                    break;
            }
        }

        private void image_ImageMouseMove(object sender, ImageMouseMoveEventArgs e)
        {

        }

        private void image_ImageMouseLeave(object sender, ImageMouseLeaveEventArgs e)
        {


        }

        private void image_ImageMouseEnter(object sender, ImageMouseEnterEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                Output.AppendLine(Color.White, "Searching for  devices...");
                Devices.Items.Clear();
                await ScanForDevices();
            }
            catch (Exception ex)
            {

            }
        }

        //private async void LearnIr_Click(object sender, System.EventArgs e)
        //{
        //    var dev = (IDevice)devs[Devices.SelectedIndex];       //
        //    if (dev.DeviceType == DeviceType.Rm)
        //    {
        //        var device = (Rm)dev;
        //        await device.EnterLearning();
        //        var signal = await device.CheckData();
        //    }

        //    if (dev.DeviceType == DeviceType.Rm2Pro)
        //    {
        //        var device = (Rm2Pro)dev;
        //        await device.EnterLearning();
        //        var signal = await device.CheckData();
        //    }

        //}


        private async Task<bool> ScanForDevices()
        {

            this.devs = await Broadlink.Discover(1);
            if (devs.Length > 0)
            {
                Output.AppendLine(Color.White, devs.Length + " Devices Have been found...");

                foreach (var dev in devs)
                {
                    Devices.Items.Add(dev.DeviceType.ToString());
                    Output.AppendLine(Color.White, "     " + dev.DeviceType.ToString() + " (" + dev.Host + ")");
                }


            }
            else
            {
                Output.AppendLine(Color.Yellow, "Device not found!");
            }


            //var rm = (Rm)devs.FirstOrDefault(d => d.DeviceType == DeviceType.Rm);

            //if (rm == null)
            //    throw new Exception("Rm2Pro Not Found");
            //else Console.WriteLine($"Rm2Pro found at {rm.Host}");

            //if (!await rm.Auth())
            //    throw new Exception("Auth Failure");

            //Console.WriteLine("Starting RF frequency learning - press any button to continue, then, press and hold the remote button...");
            //while (!Console.KeyAvailable)
            //    await Task.Delay(TimeSpan.FromMilliseconds(100));
            //while (Console.KeyAvailable)
            //    Console.ReadKey(true);

            //var cancellationSource = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            //byte[] command = null;
            //try
            //{
            //    command = await rm.LearnIRCommnad(cancellationSource.Token);

            //    if (command == null || command.Length == 0)
            //        throw new InvalidOperationException("Failed to learn RF command");
            //}
            //catch (TaskCanceledException)
            //{
            //    Console.WriteLine("Command learning cancelled");
            //    return false;
            //}

            //while (Console.KeyAvailable)
            //    Console.ReadKey(true);
            //Console.WriteLine();
            //Console.WriteLine($"RF Command learned [{command.Length}], press any key to trigger the command. Press ESC to exit...");
            //while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            //{
            //    Console.Write("Sending RF command... ");
            //    await rm.SendData(command);
            //    Console.WriteLine("RF command sent");
            //}

            return true;
        }


        private async void Scan_Click(object sender, EventArgs e)
        {
            try
            {
                Output.AppendLine(Color.White, "Searching for  devices...");
                Devices.Items.Clear();
                await ScanForDevices();
            }
            catch (Exception ex)
            {

            }
        }



        private void Devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dev = (IDevice)devs[Devices.SelectedIndex];
            Output.AppendLine(Color.Red, ((IDevice)dev).Host.ToString());
        }



        private  void LearnIR_Click(object sender, EventArgs e)
        {
            LearnIr().GetAwaiter();
        }



        private async Task<bool> LearnIr()
        {
            var dev = (IDevice)devs[Devices.SelectedIndex];
            if (dev.DeviceType == DeviceType.Rm)
            {
                var device = (Rm)dev;
                await device.Auth();
                device.EnterLearning().Wait(2000);
                var signal = await device.CheckData();
                string Hex = Signals.ProntoBytes2String(signal);
                Output.AppendLine(Color.White, Hex);

            }

            if (dev.DeviceType == DeviceType.Rm2Pro)
            {
                var device = (Rm2Pro)dev;
                await device.Auth();
                device.EnterLearning().Wait(2000);
                var signal = await device.CheckData();
                string Hex = Signals.ProntoBytes2String(signal);
                Output.AppendLine(Color.White, Hex);
            }
            return true;
        }
    }
}
