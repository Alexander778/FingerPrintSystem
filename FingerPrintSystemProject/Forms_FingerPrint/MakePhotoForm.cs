using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using WIA;
using WIAVIDEOLib;
using System.IO;


namespace Forms_FingerPrint
{
    public partial class MakePhotoForm : Form
    {

        public MakePhotoForm()
        {
            InitializeComponent();
        }

        private void MakePhotoForm_Load(object sender, EventArgs e)
        {
           
        }
        
        private void button1_Click_2(object sender, EventArgs e)
        {
            WIA.DeviceManager DeviceManager1 = new DeviceManagerClass();
            WIA.CommonDialogClass CommonDialog1 = new CommonDialogClass();

            // 1. Помогаем пользователю выбрать устройство
            WIA.Device Device1 = CommonDialog1.ShowSelectDevice(WiaDeviceType.CameraDeviceType, true, false);

            // 2. Делаем снимок
            Device1.ExecuteCommand(WIA.CommandID.wiaCommandTakePicture);

            // 3. Снова подключаемся к устройству для получения фото
            WIA.Device Device1a = null;
            foreach (DeviceInfo dev_item in DeviceManager1.DeviceInfos)
            {
                // Перечисляем все устройства
                if (dev_item.DeviceID == Device1.DeviceID)
                {
                    // и подключаемся к тому, чей DeviceID совпадает с ранее выбранным
                    Device1a = dev_item.Connect();
                    break;
                }
            }

            // 4. Находим какой объект нам нужен
            WIA.Item newItem = Device1a.Items[Device1a.Items.Count];

            // 5. Читаем файл из устройства
            WIA.ImageFile newImage = (ImageFile)CommonDialog1.ShowTransfer(newItem, WIA.FormatID.wiaFormatJPEG, false);

            // 6. Преобразуем полученные данные в вектор
            WIA.Vector newVector = newImage.FileData;

            // 7. Забираем из вектора байтовый массив, содержащий изображение
            Byte[] bytBLOBData = (Byte[])newVector.get_BinaryData();

            // 8. Преобразуем массив в поток
            MemoryStream stmBLOBData = new MemoryStream(bytBLOBData);

            // 9. Преобразуем поток в изображение и присваиваем его элементу PictureBox
            pictureBox1.Image = Image.FromStream(stmBLOBData);

            // 10. Режим масштабирования Zoom помогает увидеть весь кадр (в целях отладки)
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
        
    





