using FilterEdgeDetection.BLL;
using FilterEdgeDetection.IOfile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterEdgeDetection
{
    public partial class WinForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        Bitmap selectedSource = null;

        private Bitmap filterResult = null;

        private IPictureIO pictureIO;
        private  IPictureManipulation pictureManipulation;
        private IEdge edge;


        public WinForm(IPictureIO pictureIO, IPictureManipulation pictureManipulation, IEdge edge)
        {
            this.pictureIO = pictureIO;
            this.pictureManipulation = pictureManipulation;
            this.edge = edge;


        }

        public WinForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Voir si nécessaire ce bout de code : car sinon pas de path


            this.pictureIO = new PictureIO();
            this.edge = new Edge();

            originalBitmap = pictureIO.openPicture();

            previewBitmap = originalBitmap;

            //A enlever commentaire dès que le EDGE est fait
            previewBitmap = edge.CopyToSquareCanvas(previewBitmap, pictureBox1.Width);
            pictureBox1.Image = previewBitmap;

            ApplyFilter(true) ;
           
        }


        private void ApplyFilter(bool preview)
        {
            this.pictureManipulation = new Filter();

            switch (cmbFilters.SelectedItem.ToString())
            {
                case "Black and white":
                    filterResult = pictureManipulation.BlackWhite(originalBitmap);
                    break;

                case "Night filter":
                    filterResult = pictureManipulation.ApplyFilter(originalBitmap,1,1,1,25);
                    break;

                //The default is "None" because there is not risk that one day we remove the "none"
                default:
                    //When the user click on "none" we come back to the original picture
                    filterResult = originalBitmap;
                    break;
            }

            resultBitmap = filterResult;

            if (resultBitmap != null)
            {
               pictureBox1.Image = resultBitmap;                
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            this.pictureIO = new PictureIO();
            pictureIO.savePicture(previewBitmap);
        }
        

        private void filterListener(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }
    }
}
