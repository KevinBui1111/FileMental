using BrightIdeasSoftware;
using KevinHelper;
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

namespace FileMental
{
    public partial class FrmMain : Form
    {
        string dirCompare;
        KFile rootLocal;
        public FrmMain()
        {
            InitializeComponent();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            SysImageListHelper helper = new SysImageListHelper(olvFileList);
            olvColumn1.ImageGetter = delegate (object o)
            {
                var item = o as KFile;
                return helper.GetImageIndex(item.Name, item.IsFolder);
            };
            RowBorderDecoration rbd = new RowBorderDecoration();
            rbd.BorderPen = new Pen(Color.DodgerBlue, 1);
            rbd.FillBrush = new SolidBrush(Color.Transparent);
            rbd.BoundsPadding = new Size(0, 0);
            rbd.CornerRounding = 0.0f;

            //olvFileList.HotItemStyle = new HotItemStyle();
            //olvFileList.HotItemStyle.BackColor = Color.WhiteSmoke;
            //olvFileList.HotItemStyle.Decoration = rbd;
            olvFileList.SelectedRowDecoration = rbd;

            var dir = await JobWalkDirectories.LoadFolderAsync(@"E:\Downloads\");
            //rootLocal = new KFile();
            //rootLocal.Children.AddRange(dir.Children);
            //dir.Parent = rootLocal;
            show_folder_grid(dir);
        }

        private async void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            dirCompare = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

            var dir = await JobWalkDirectories.LoadFolderAsync(dirCompare);
            rootLocal = new KFile();
            rootLocal.Children.AddRange(dir.Children);
            dir.Parent = rootLocal;
            show_folder_grid(rootLocal);
        }
        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            string folder = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            bool is_folder = Directory.Exists(folder);
            if (is_folder && e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        void show_folder_grid(KFile item)
        {
            if (item.Parent != null)
            {
                KFile parentFolder = new KFile { Name = "..", Parent = item.Parent };
                var list = new List<KFile> { parentFolder };
                list.AddRange(item.Children.Cast<KFile>());
                olvFileList.SetObjects(list);
            }
            else
                olvFileList.SetObjects(item.Children);
        }

        private async void olvFileList_DroppedAsync(object sender, BrightIdeasSoftware.OlvDropEventArgs e)
        {
            dirCompare = ((string[])((IDataObject)e.DataObject).GetData(DataFormats.FileDrop))[0];

            var dir = await JobWalkDirectories.LoadFolderAsync(dirCompare);
            //rootLocal = new KFile();
            //rootLocal.Children.AddRange(dir.Children);
            //dir.Parent = rootLocal;
            show_folder_grid(dir);
        }

        private void olvFileList_CanDrop(object sender, BrightIdeasSoftware.OlvDropEventArgs e)
        {
            if (((DataObject)e.DataObject).GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        int count = 0;
        private void olvFileList_ItemActivate(object sender, EventArgs e)
        {
            var file = (KFile)olvFileList.SelectedObject;
            Text = $"{file?.Name} - {count++}";
        }
    }
}
