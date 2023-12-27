using Accessibility;
using Substrate;
using Substrate.Core;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Text;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        List<BiomeInfo> Biomes = new List<BiomeInfo>();
        
        int tainted = 0;
        int clean = 0;
        public MainForm()
        {
            InitializeComponent();
            Biomes.Add(new BiomeInfo( 0, "Ocean",                           Color.FromArgb(  0,   0, 128)));
            Biomes.Add(new BiomeInfo( 1, "Plains",                          Color.FromArgb(174, 189,  78))); //
            Biomes.Add(new BiomeInfo( 2, "Desert",                          Color.FromArgb(246, 193,  50)));
            Biomes.Add(new BiomeInfo( 3, "ExtremeHills",                    Color.FromArgb(195, 134,  97)));//
            Biomes.Add(new BiomeInfo( 4, "Forest",                          Color.FromArgb( 40, 194,  39)));
            Biomes.Add(new BiomeInfo( 5, "Taiga",                           Color.FromArgb(201, 197, 200)));
            Biomes.Add(new BiomeInfo( 6, "Swampland",                       Color.FromArgb(116, 148,  78)));
            Biomes.Add(new BiomeInfo( 7, "River",                           Color.FromArgb(  4, 198, 201)));
            Biomes.Add(new BiomeInfo( 8, "Hell",                            Color.FromArgb(157, 115, 115))); //was 255,255,0 (should be fixed in all images.. sigh)
            Biomes.Add(new BiomeInfo (9, "Sky",                             Color.FromArgb(255,   0, 255)));
            Biomes.Add(new BiomeInfo(10, "FrozenOcean",                     Color.FromArgb(160, 243, 238)));
            Biomes.Add(new BiomeInfo(11, "FrozenRiver",                     Color.FromArgb(  0,   0, 255)));
            Biomes.Add(new BiomeInfo(12, "IcePlains",                       Color.FromArgb(201, 197, 200)));//
            Biomes.Add(new BiomeInfo(13, "IceMountains",                    Color.FromArgb(169, 165, 167)));//
            Biomes.Add(new BiomeInfo(14, "MushroomIsland",                  Color.FromArgb(128,  71, 168)));
            Biomes.Add(new BiomeInfo(15, "MushroomIslandShore",             Color.FromArgb(130,  95, 154)));
            Biomes.Add(new BiomeInfo(16, "Beach",                           Color.FromArgb(234, 230,   2)));
            Biomes.Add(new BiomeInfo(17, "DesertHills",                     Color.FromArgb(197, 155,  40)));
            Biomes.Add(new BiomeInfo(18, "ForestHills",                     Color.FromArgb( 41, 125,  24)));//
            Biomes.Add(new BiomeInfo(19, "TaigaHills",                      Color.FromArgb(169, 165, 167)));
            Biomes.Add(new BiomeInfo(20, "ExtremeHillsEdge",                Color.FromArgb(108,  85,  24)));
            Biomes.Add(new BiomeInfo(21, "Jungle",                          Color.FromArgb( 27, 150,  40)));
            Biomes.Add(new BiomeInfo(22, "JungleHills",                     Color.FromArgb( 18, 101,  26)));
            Biomes.Add(new BiomeInfo(23, "JungleEdge",                      Color.FromArgb(167, 197, 217)));

            Biomes.Add(new BiomeInfo(27, "Birch Forest",                    Color.FromArgb( 86, 151,  68)));//
            Biomes.Add(new BiomeInfo(28, "Birch Forest Hills",              Color.FromArgb( 41, 125,  24)));//

            Biomes.Add(new BiomeInfo(35, "Savanna",                         Color.FromArgb(203, 165,  76)));//
            Biomes.Add(new BiomeInfo(36, "Savanna Plateu",                  Color.FromArgb(150, 120,  60)));//

            Biomes.Add(new BiomeInfo(45, "MSDune",                          Color.FromArgb(216, 176,  72)));//
            Biomes.Add(new BiomeInfo(46, "MSLakeshore2",                    Color.FromArgb(180, 164, 108)));//
            Biomes.Add(new BiomeInfo(47, "MSGravelBeach",                   Color.FromArgb(118, 118, 118)));//
            Biomes.Add(new BiomeInfo(48, "MSExtreme Hills2",                Color.FromArgb(160, 104,  68)));//
            Biomes.Add(new BiomeInfo(49, "MSExtreme Hills Edge2",           Color.FromArgb(131, 107,  39)));//
            //Biomes.Add(new BiomeInfo(50, "NoIdea2", Color.FromArgb(50, 200, 200, 255)));
            Biomes.Add(new BiomeInfo(51, "MSTheArctic",                     Color.FromArgb(  0, 227, 195))); //

            Biomes.Add(new BiomeInfo(52, "MSMonumentRocks",                 Color.FromArgb(128, 103,  24))); //
            Biomes.Add(new BiomeInfo(53, "MSMonumentRocksPeak",             Color.FromArgb( 79,  61,  15))); //
            Biomes.Add(new BiomeInfo(54, "MSMonumentValley",                Color.FromArgb(202, 168,  34))); //
            Biomes.Add(new BiomeInfo(55, "MSMonumentRocksBorder",           Color.FromArgb(152, 124,  28))); //
            Biomes.Add(new BiomeInfo(56, "MSErodedCoast",                   Color.FromArgb(189, 194,  39))); //
            Biomes.Add(new BiomeInfo(57, "MSMonumentArches",                Color.FromArgb(146,  87,  42))); //
            Biomes.Add(new BiomeInfo(58, "MSMonumentRocksLower",            Color.FromArgb(167, 105,  45))); //
            Biomes.Add(new BiomeInfo(59, "MSMonumentArchesLower",           Color.FromArgb(167, 105,  45))); //

            Biomes.Add(new BiomeInfo(60, "MSMonumentArchesRiver",           Color.FromArgb(189, 194,  39)));//
            Biomes.Add(new BiomeInfo(61, "MSMonumentArchesLowerRiver",      Color.FromArgb(152, 124,  28)));//
            Biomes.Add(new BiomeInfo(62, "MSMonumentArchesMediumRiver",     Color.FromArgb(126, 105,  22)));//
            Biomes.Add(new BiomeInfo(63, "MSLava",                          Color.FromArgb(235,  92, 140)));//
            Biomes.Add(new BiomeInfo(64, "MSWesterwald",                    Color.FromArgb(132, 131,  29)));//
            Biomes.Add(new BiomeInfo(65, "MSFloatingCity",                  Color.FromArgb(  3, 135, 129)));//
            Biomes.Add(new BiomeInfo(66, "MSFloatingCityCenter",            Color.FromArgb(  0, 109, 103)));//
            Biomes.Add(new BiomeInfo(67, "MSFloatingCityBorder",            Color.FromArgb(  3, 189, 180)));//
            Biomes.Add(new BiomeInfo(68, "MSFloatingCityBorder2",           Color.FromArgb(  3, 157, 150)));//
            Biomes.Add(new BiomeInfo(69, "MSFloatingCityBorder3",           Color.FromArgb(  3, 113, 109)));//
            //Biomes.Add(new BiomeInfo(70, "NoIdea2",     Color.FromArgb(70,200, 200, 255)));
            Biomes.Add(new BiomeInfo(71, "MSVulcano",                       Color.FromArgb(235,   0,  22)));//
            Biomes.Add(new BiomeInfo(72, "MSBryce",                         Color.FromArgb(150, 112,  46)));//
            Biomes.Add(new BiomeInfo(73, "MSGrassland",                     Color.FromArgb(151, 252,   0)));//
            Biomes.Add(new BiomeInfo(74, "MSLakeshore",                     Color.FromArgb(125, 155,  59)));//
            Biomes.Add(new BiomeInfo(75, "MSLakes",                         Color.FromArgb(0  , 156, 156)));//
            Biomes.Add(new BiomeInfo(77, "TAOceanInBorder",                 Color.FromArgb(50 , 50 , 252)));//

            Biomes.Add(new BiomeInfo(81, "TAOceanRich",                     Color.FromArgb(  0,   0, 132)));//
            Biomes.Add(new BiomeInfo(83, "TAJungleNetherrack",              Color.FromArgb( 44,  97,  40)));//
            
            Biomes.Add(new BiomeInfo(132, "Flower Forest",                  Color.FromArgb( 86, 151,  68)));//

            Biomes.Add(new BiomeInfo(140, "IceSpikePlains",                 Color.FromArgb(150, 230, 228)));

            Biomes.Add(new BiomeInfo(192, "Tainted Land",                   Color.FromArgb(255,   0, 110)));//
            Biomes.Add(new BiomeInfo(193, "Magical Forest",                 Color.FromArgb( 41,  89,  93)));//
            Biomes.Add(new BiomeInfo(194, "Eerie",                          Color.FromArgb( 64,  64,  64)));//

        }

        private void btnSnapshot_Click(object sender, EventArgs e)
        {
            //Open the world file, AnvilWorld based on the version of minecraft
            var w = AnvilWorld.Open(@"D:\Games\Technic\modpacks\blightfall\saves\HonkFall\");
            
            //Get a chucnk manager. This allows access to each chunk in the world file through an iterator which is perfect for this program
            RegionChunkManager rcm = w.GetChunkManager();

            //Bitmap size based on the chunks we want to map, no error checking for in-bounds later on!
            int width = (110 + 1) * 16; //(116 * 16) + (--14 * 16);
            int height = (135 + 1) * 16;

            Bitmap bmap = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmap);
            
            //Assume entire map is tainted and fill. This speeds up generation early on
            g.FillRectangle(new SolidBrush(GetColorFromBiomeID(192)), 0, 0, bmap.Width, bmap.Height);

            //For printing the change in taint since last snapshot. Handy to gauge progress.
            int oldtainted = tainted;
            int oldclean = clean;


            tainted = 0;
            clean = 0;
            StringBuilder sb = new StringBuilder();
            using (BmpPixelSnoop bps = new BmpPixelSnoop(bmap))
            {
                foreach (ChunkRef cf in rcm)
                {
                    //skip chunks outside the mapping-area
                    if (cf.X < 0 || cf.Z < 0 || cf.X > 110 || cf.Z > 135)
                    {
                        //txtDebug.Text += "ignored :p" + Environment.NewLine;
                    }
                    else
                    {
                        ProcessBiomes(cf, bps);
                    }
                }
            }
            txtDebug.Text += "T[" + tainted + "] Clean[" + clean + "] TC[" + (tainted - oldtainted) + "]" + Environment.NewLine;

            pG.BackgroundImageLayout = ImageLayout.Zoom;
            pG.BackgroundImage = bmap;
            pB.Image = bmap;

            //Save bitmap. Tainted block number added so I can generate a "progress bar" on the timelapse if I want to in future
            string fname = string.Format($"Blightfall_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}__{DateTime.Now.Hour}_{DateTime.Now.Minute}_{DateTime.Now.Second}___{tainted}.png");
            bmap.Save(fname,ImageFormat.Png);
            txtDebug.Text += "Done." + Environment.NewLine;
        }
        private void ProcessBiomes(ChunkRef cf, BmpPixelSnoop b)
        {
            AnvilBiomeCollection abc = cf.Biomes;
            //Each chunk is 16x16 and each coordinate has a single biome integer.
            //In future versions biome can change by height so do not assume this in modern minecraft!
            for (int x = 0; x < 16; x++)
            {
                for (int z = 0; z < 16; z++)
                {
                    int ax = (cf.X * 16) + x;
                    int az = (cf.Z * 16) + z;
                    int biomeid = cf.Biomes.GetBiome(x, z);
                    if(biomeid == 192)
                    {
                        //image is filled with taint as background so no need to setpixel here.
                        tainted++;
                    }
                    else
                    {
                        //See color table at top of file.
                        b.SetPixel(ax, az, GetColorFromBiomeID(biomeid));
                        clean++;
                    }
                    //used to find the biome id of new biomes before color map was created. Handy if I missed something ;p
                    //if(ax == 1420 && az == 1140)
                    //{
                    //    txtDebug.Text += "Biome id fxdd3 at coords: " + biomeid;
                    //}

                }
            }
        }
        private Color GetColorFromBiomeID(int biomeid)
        {
            BiomeInfo bi = Biomes.Find(item => item.BiomeID == biomeid);
            if (bi != null)
            {
                return bi.BiomeColor;
            }
            else
            {

                //this gets extremely spammy in textbox so mostly used for setting a breakpoint when looking for
                //new biomes. Should not happen in a blightfall map unless biome id change in the future which I doubt.
                txtDebug.Text += "Unknown biome:" + biomeid;
                
                // set the alpha channel to the biome id so we can fix the generated bitmaps later if we want to
                // by search-replacing on the alpha channel. Neat little trick if I say so myself :p
                return Color.FromArgb(biomeid, 255, 255, 255); 
            }
        }

        private void btnImageLayout_Click(object sender, EventArgs e)
        {
            if (pG.BackgroundImageLayout != ImageLayout.Zoom)
            {
                pG.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                pG.BackgroundImageLayout = ImageLayout.Center;
            }
        }

    }

    public class BiomeInfo
    {
        public BiomeInfo(int _biomeid, string _name, Color _color)
        {
            BiomeID = _biomeid;
            Name = _name;
            BiomeColor = _color;
        }
        public int BiomeID { get; set; }
        public string Name { get; set; }
        public Color BiomeColor { get; set; }
    }
}