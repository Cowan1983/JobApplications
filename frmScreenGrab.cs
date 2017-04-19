using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace JobApplication
{
    public partial class frmScreenGrab : Form
    {
        //The byte[] for saving into the database
        public byte[] ScreenGrab { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public frmScreenGrab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor that takes Image data
        /// </summary>
        /// <param name="imageData">byte[] of image data</param>
        public frmScreenGrab(byte[] imageData) : this()
        {
            ScreenGrab = imageData;

            //Convert the byte[] to Image
            picBoxJobLead.Image = ConvertByteArrayToImage(imageData);

        }

        /// <summary>
        /// Close the ScreenGrab form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Copy the clipboard data as an image and show it in the PictureBox control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPasteFrmClipboard_Click(object sender, EventArgs e)
        {
            picBoxJobLead.Image = Clipboard.GetImage();

            //Convert the image pasted into a byte[] for saving
            ScreenGrab = ConvertImageToByteArray(picBoxJobLead.Image);

        }

        //As we don't have a Utilities Library and I can't be bothered creating one for the two useful functions this form uses,
        //I will just add them here

        public byte[] ConvertImageToByteArray(Image myImage)
        {
            MemoryStream ms = new MemoryStream();

            myImage.Save(ms, ImageFormat.Jpeg);
            byte[] imageArray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(imageArray, 0, imageArray.Length);

            return imageArray;
        }

        public Image ConvertByteArrayToImage(byte[] myByteArray)
        {
            //Set the screen grab picture
            MemoryStream ms = new MemoryStream(myByteArray);
            return Image.FromStream(ms);
        }

        
    }
}
