using FilterEdgeDetection.BLL;
using FilterEdgeDetection.IOfile;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FilterEdgeDetection
{
    public partial class WinForm : Form
    {
        //Declaration of the bitmap we need 
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;

        private Bitmap filterResult = null;
        private Bitmap edgeResult = null;

        
        //Call interfaces needed
        private IPictureIO pictureIO;
        private  IFilter pictureManipulation;
        private IEdge edge;


        public WinForm(IPictureIO pictureIO, IFilter pictureManipulation, IEdge edge)
        {

            //Instenciate interfaces
            this.pictureIO = pictureIO;
            this.pictureManipulation = pictureManipulation;
            this.edge = edge;


        }

        public WinForm()
        {
            InitializeComponent();
            //The combobox start to the index 0 = "none"
            cmbFilters.SelectedIndex = 0;
            cmbEdge.SelectedIndex = 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            //Call classes needed
            this.pictureIO = new PictureIO();
            this.edge = new Edge();

            originalBitmap = pictureIO.openPicture();

            previewBitmap = originalBitmap;

            //Size in the picture box
            previewBitmap = edge.CopyToSquareCanvas(previewBitmap, pictureBox1.Width);

            //Put the picture in the picture box
            pictureBox1.Image = previewBitmap;

            ApplyFilter() ;
           
        }

        //Method to apply the filter
        private void ApplyFilter()
        {
            //Nécaissaire ?
            if (previewBitmap == null ||  cmbEdge.SelectedIndex == -1)
            {
                return;
            }

            this.pictureManipulation = new Filter();

            switch (cmbFilters.SelectedItem.ToString())
            {
                case "Black and white":
                    filterResult = pictureManipulation.BlackWhite(originalBitmap);
                    break;

                case "Night Filter":
                    filterResult = pictureManipulation.ApplyFilter(originalBitmap,1,1,1,25);
                    break;
                    

                //The default is "None" because there is not risk that one day we remove the "none"
               default:
                    //When the user click on "none" we come back to the original picture
                    filterResult = originalBitmap;
                    break;
            }

            //Call the method to apply the edge
            ApplyEdge();
           
         
            
        }

        //Method to apply the edge
        private void ApplyEdge()
        {
            
            if (filterResult == null || cmbEdge.SelectedIndex == -1)
            {
                return;
            }
            
            this.edge = new Edge();

          

            switch (cmbEdge.SelectedItem.ToString())
            {

                case "Prewitt":
                    edgeResult = edge.PrewittFilter(filterResult);
                    break;

                case "Kirsch":
                    edgeResult = edge.KirschFilter(filterResult);
                    break;

                //The default is "None" because there is not risk that one day we remove the "none"
                default:
                    //When the user click on "none" we come back to the filter results beacause we can't have an edge without a filter
                    edgeResult = filterResult;
                    break;
            }

            //Put the picture with the edge in the picturebox
            if (edgeResult != null)
            {
                pictureBox1.Image = edgeResult;
                resultBitmap = edgeResult;
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            this.pictureIO = new PictureIO();
            pictureIO.savePicture(resultBitmap);
        }

        

        private void filterListener(object sender, EventArgs e)
        {
            //If the user choose "none" for the filter, the combobox for de edge is gray out and we remove the edge detection
            if (cmbFilters.SelectedIndex == 0)
            {
                labelCF.Visible = true;
                cmbEdge.SelectedIndex = cmbEdge.FindStringExact("None");
                cmbEdge.Enabled = false;

            }
            else

            {
                labelCF.Visible = false;
                //When the user has chosen her filter, we can choose the edge
                this.cmbEdge.Enabled = true;
            }

            ApplyFilter();

        }

        private void edgeListener(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
