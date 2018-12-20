﻿using FilterEdgeDetection.BLL;
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

        private Bitmap filterResult = null;

        private IPictureIO pictureIO;
        private readonly IPictureManipulation pictureManipulation;


        public WinForm(IPictureIO pictureIO, IPictureManipulation pictureManipulation)
        {
            this.pictureIO = pictureIO;
            this.pictureManipulation = pictureManipulation;
           
        }

        public WinForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Voir si nécessaire ce bout de code : car sinon pas de path

                this.pictureIO = new PictureIO();
                previewBitmap = pictureIO.openPicture();
          
            //A enlever commentaire dès que le EDGE est fait
            //previewBitmap = originalBitmap.CopyToSquareCanvas(pictureBox1.Width);
            pictureBox1.Image = previewBitmap;

             //   ApplyFilter(true);
           
        }


        private void ApplyFilter()
        {
            if (RB_BlackWhite.Checked)
            {
                filterResult = pictureManipulation.BlackWhite(previewBitmap);
              
            }

            else
            {
                filterResult = pictureManipulation.ApplyFilter(previewBitmap, 1, 1, 1, 25);
               
            }
                


        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            pictureIO.savePicture(previewBitmap);
        }
    }
}
