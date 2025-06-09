namespace Lab19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateListView(listViewCPU, WmiHelper.GetProperties("Win32_Processor", "Name", "Manufacturer", "Description"));
            PopulateListView(listViewGPU, WmiHelper.GetProperties("Win32_VideoController", "Name", "VideoProcessor", "DriverVersion", "AdapterRAM"));
            var storage = WmiHelper.GetInstances("Win32_DiskDrive", "Caption", "Size");
            var cdrom = WmiHelper.GetInstances("Win32_CDROMDrive", "Name", "Drive");
            var allDrives = storage.Concat(cdrom).ToList();
            PopulateListView(listViewDrive, allDrives);
            PopulateListView(listViewMotherboard, WmiHelper.GetProperties("Win32_BaseBoard", "Manufacturer", "Product", "SerialNumber"));
            var nets = WmiHelper.GetInstances("Win32_NetworkAdapterConfiguration", "Description", "MACAddress", "IPAddress");
            PopulateListView(listViewNetwork, nets);
            PopulateListView(listViewBIOS, WmiHelper.GetProperties("Win32_BIOS", "Manufacturer", "SMBIOSBIOSVersion", "ReleaseDate"));
        }
        private void PopulateListView(ListView lv, Dictionary<string, string> data)
        {
            lv.Items.Clear();
            foreach (var kv in data)
            {
                var item = new ListViewItem(kv.Key);
                item.SubItems.Add(kv.Value);
                lv.Items.Add(item);
            }
        }
        private void PopulateListView(ListView lv, List<Dictionary<string, string>> list)
        {
            lv.Items.Clear();
            foreach (var dict in list)
            {
                foreach (var kv in dict)
                {
                    var item = new ListViewItem(kv.Key);
                    item.SubItems.Add(kv.Value);
                    lv.Items.Add(item);
                }
                lv.Items.Add(new ListViewItem(["––––––––", "––––––––"]));
            }
        }
    }
}
