using PandasMemorialMemory.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace PandasMemorialMemory.Classes
{
    class RomanianCode
    {
        //Kinda worked

        //private bool allowClick = true;
        //private PictureBox firstGuess;
        //private readonly Random random = new Random();
        //private readonly Timer clickTimer = new Timer();
        //int ticks = 30;
        //readonly Timer timer = new Timer { Interval = 100 };

        //public Form1()
        //{
        //    InitializeComponent();
        //    SetRandomImages();
        //    HideImages();
        //    StartGameTimer();
        //    clickTimer.Interval = 1000;
        //    clickTimer.Tick += ClickTimer_Tick;
        //}

        //public PictureBox[] PictureBoxes
        //{
        //    get
        //    {
        //        return gameArea.Controls.OfType<PictureBox>().ToArray();
        //    }
        //}

        //public static IEnumerable<Image> Images
        //{
        //    get
        //    {
        //        return new Image[]
        //        {
        //            Resources.perlypanda1,
        //            Resources.perlypanda2,
        //            Resources.perlypanda3,
        //            Resources.perlypanda4,
        //            Resources.perlypanda5,
        //            Resources.perlypanda6,
        //            Resources.perlypanda7,
        //            Resources.perlypanda8,
        //            Resources.perlypanda9,
        //            Resources.perlypanda10,
        //            Resources.perlypanda11,
        //            Resources.perlypanda12 };
        //    }
        //}

        //private void StartGameTimer()
        //{
        //    timer.Start();
        //    timer.Tick += delegate
        //    {
        //        ticks--;
        //        if (ticks == -1)
        //        {
        //            timer.Stop();
        //            ResetImages();
        //        }
        //        var time = TimeSpan.FromSeconds(ticks);
        //        lblTime.Text = "00:" + time.ToString("ss");
        //    };
        //}

        //private void ResetImages()
        //{
        //    foreach (var pic in PictureBoxes)
        //    {
        //        pic.Tag = null;
        //        pic.Visible = true;
        //    }

        //    HideImages();
        //    SetRandomImages();
        //    ticks = 30;
        //    timer.Start();
        //}

        //private void HideImages()
        //{
        //    foreach (var pic in PictureBoxes)
        //    {
        //        pic.Image = Resources.cardback;
        //        pic.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //}

        //private PictureBox GetFreeSlot()
        //{
        //    var num = 0;

        //    do
        //    {
        //        num = random.Next(0, PictureBoxes.Count());
        //    } while (PictureBoxes[num].Tag != null);

        //    return PictureBoxes[num];
        //}

        //private void SetRandomImages()
        //{
        //    foreach (var image in Images)
        //    {
        //        GetFreeSlot().Tag = image;
        //        GetFreeSlot().Tag = image;
        //    }
        //}

        //private void ClickImage(object sender, EventArgs e)
        //{
        //    if (!allowClick) return;

        //    var pic = (PictureBox)sender;

        //    if (firstGuess == null)
        //    {
        //        firstGuess = pic;
        //        pic.Image = (Image)pic.Tag;
        //        return;
        //    }
        //    pic.Image = (Image)pic.Tag;
        //    if (pic.Image == firstGuess.Image && pic != firstGuess)
        //    {
        //        pic.Visible = firstGuess.Visible = false;
        //        {
        //            firstGuess = pic;
        //        }

        //        HideImages();
        //    }
        //    else
        //    {
        //        allowClick = false;
        //        clickTimer.Start();
        //    }
        //    firstGuess = null;
        //    if (PictureBoxes.Any(p => p.Visible)) return;

        //    MessageBox.Show("You won!", "Harambe", MessageBoxButtons.OK);
        //    ResetImages();

        //}

        //private void ClickTimer_Tick(object sender, EventArgs e)
        //{
        //    HideImages();
        //    allowClick = true;
        //    clickTimer.Stop();
        //}
    }
}
