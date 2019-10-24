using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;


namespace lmv
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void FAdrss_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LAdrss_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PlugCard_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void gmap_Load(object sender, EventArgs e)
        {
            // Настройки для компонента GMap

            gmap.Bearing = 0;

            // Перетаскивание правой кнопки мыши

            gmap.CanDragMap = true;

            // Перетаскивание карты левой кнопкой мыши

            gmap.DragButton = MouseButtons.Left;



            gmap.GrayScaleMode = true;



            // Все маркеры будут показаны

            gmap.MarkersEnabled = true;

            // Максимальное приближение

            gmap.MaxZoom = 18;

            // Минимальное приближение

            gmap.MinZoom = 2;

            // Курсор мыши в центр карты

            gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;



            // Отключение нигативного режима

            gmap.NegativeMode = false;

            // Разрешение полигонов

            gmap.PolygonsEnabled = true;

            // Разрешение маршрутов

            gmap.RoutesEnabled = true;

            // Скрытие внешней сетки карты

            gmap.ShowTileGridLines = false;

            // При загрузке 10-кратное увеличение

            gmap.Zoom = 10;



            // Изменение размеров

            // gmap.Dock = DockStyle.Fill;

                                    // Чья карта используется

            gmap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;

                                    // Загрузка этой точки на карте

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            gmap.Position = new GMap.NET.PointLatLng(47.817577, 35.183953);



            // Создаём новый список маркеров

            GMapOverlay markersOverlay = new GMapOverlay("markers");



            // Инициализация красного маркера с указанием его коордиант

            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(47.817577, 35.183953), GMarkerGoogleType.red);

            marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
            

            // Текст отображаемый с маркером

            marker.ToolTipText = "Software Technologies";
        
            // Добавляем маркер в список маркеров

            markersOverlay.Markers.Add(marker);

            gmap.Overlays.Add(markersOverlay);
   


            // Установка максимального, минимального и текущего значения элемента управления

            //trackBar1.Maximum = 18;

            //trackBar1.Minimum = 2;

            //trackBar1.Value = (int)gmap.Zoom;

        }

    
    }
}
