using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeWatermarker
{
    /// <summary>
    /// WaterMark images in a batch using clsWaterMark
    /// 
    /// FUTURE IMPLAMENTATIONS: Thread with Progress indication by events
    /// 
    /// </summary>
    class clsBatchWaterMarker
    {
        private List<clsImageItem> images;

        public clsBatchWaterMarker(ref List<clsImageItem> imagesList)
        {
            images = imagesList;
        }

        /// <summary>
        /// WaterMark the list of images
        /// </summary>
        public void WaterMark()
        {
            //clsWaterMarker WaterMarker = new clsWaterMarker();

            //foreach (clsImageItem item in images)
            //{
            //    WaterMarker.CreateAndInsertWaterMark(item, WaterMark);
            //}

            clsWaterMarker WaterMarker = new clsWaterMarker();

            foreach (clsImageItem item in images)
            {
                item.Image = WaterMarker.CreateAndInsertWaterMark(item, item.WaterMarks[0]);
            }

        }

        /// <summary>
        /// WaterMark the list of images with a specific WaterMark
        /// </summary>
        public void WaterMark(clsWaterMark WaterMark)
        {
            //clsWaterMarker WaterMarker = new clsWaterMarker();

            //foreach (clsImageItem item in images)
            //{
            //    WaterMarker.CreateAndInsertWaterMark(item, WaterMark);
            //}
            throw new Exception("NOT YET IMPLEMENTED!");
        }


        /// <summary>
        /// WaterMark the list of images with a specific ImageWaterMark
        /// </summary>
        public void ImageWaterMark(clsImageWaterMark WaterMark)
        {
            clsWaterMarker WaterMarker = new clsWaterMarker();

            foreach(clsImageItem item in images)
            {
                WaterMarker.CreateAndInsertWaterMark(item, WaterMark);
            }
        }
    }
}
